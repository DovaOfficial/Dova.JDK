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

namespace Dova.JDK.jdk.@internal.jshell.tool;

[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool;", "public")]
public partial class JShellTool
	: Dova.JDK.java.lang.Object
	, Dova.JDK.jdk.@internal.jshell.tool.MessageHandler
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JShellTool()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/JShellTool;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROMPT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTINUATION_PROMPT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LINEBREAK", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ID", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RERUN_ID", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RERUN_PREVIOUS", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SET_SUB", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RECORD_SEPARATOR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RB_NAME_PREFIX", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VERSION_RB_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "L10N_RB_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cmdin", "Ljava/io/InputStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cmdout", "Ljava/io/PrintStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cmderr", "Ljava/io/PrintStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "console", "Ljava/io/PrintStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "userin", "Ljava/io/InputStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "userout", "Ljava/io/PrintStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "usererr", "Ljava/io/PrintStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prefs", "Ljdk/internal/jshell/tool/PersistentStorage;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "envvars", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "locale", "Ljava/util/Locale;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interactiveTerminal", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "feedback", "Ljdk/internal/jshell/tool/Feedback;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "versionRB", "Ljava/util/ResourceBundle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outputRB", "Ljava/util/ResourceBundle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "input", "Ljdk/internal/jshell/tool/IOContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "regenerateOnDeath", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "live", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interactiveModeBegun", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "options", "Ljdk/internal/jshell/tool/JShellTool$Options;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "analysis", "Ljdk/jshell/SourceCodeAnalysis;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "state", "Ljdk/jshell/JShell;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shutdownSubscription", "Ljdk/jshell/JShell$Subscription;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BUILT_IN_EDITOR", "Ljdk/internal/jshell/tool/JShellTool$EditorSetting;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "debug", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "debugFlags", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "testPrompt", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "startup", "Ljdk/internal/jshell/tool/Startup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isCurrentlyRunningStartup", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "executionControlSpec", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "editor", "Ljdk/internal/jshell/tool/JShellTool$EditorSetting;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exitCode", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EDITOR_ENV_VARS", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "replayableHistory", "Ljdk/internal/jshell/tool/JShellTool$ReplayableHistory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "replayableHistoryPrevious", "Ljdk/internal/jshell/tool/JShellTool$ReplayableHistory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STARTUP_KEY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EDITOR_KEY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODE_KEY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODE2_KEY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FEEDBACK_KEY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REPLAY_RESTORE_KEY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INDENT_KEY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BUILTIN_FILE_PATTERN", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BUILTIN_FILE_PATH_FORMAT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INT_PREFIX", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OUTPUT_WIDTH", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_INDENT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OPTION_PRE_PATTERN", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OPTION_PATTERN", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OPTION_VALUE_PATTERN", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mainNamespace", "Ljdk/internal/jshell/tool/JShellTool$NameSpace;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "startNamespace", "Ljdk/internal/jshell/tool/JShellTool$NameSpace;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "errorNamespace", "Ljdk/internal/jshell/tool/JShellTool$NameSpace;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentNameSpace", "Ljdk/internal/jshell/tool/JShellTool$NameSpace;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mapSnippet", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_COMPLETION_PROVIDER", "Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SNIPPET_HISTORY_OPTION_COMPLETION_PROVIDER", "Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SAVE_OPTION_COMPLETION_PROVIDER", "Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HISTORY_OPTION_COMPLETION_PROVIDER", "Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SNIPPET_OPTION_COMPLETION_PROVIDER", "Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMAND_LINE_LIKE_OPTIONS_COMPLETION_PROVIDER", "Ljdk/internal/jshell/tool/JShellTool$FixedCompletionProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RELOAD_OPTIONS_COMPLETION_PROVIDER", "Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SET_MODE_OPTIONS_COMPLETION_PROVIDER", "Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FILE_COMPLETION_PROVIDER", "Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARG_OPTIONS", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "commands", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "commandCompletions", "Ljdk/internal/jshell/tool/ContinuousCompletionProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SET_SUBCOMMANDS", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/InputStream;Ljava/io/PrintStream;Ljava/io/PrintStream;Ljava/io/PrintStream;Ljava/io/InputStream;Ljava/io/PrintStream;Ljava/io/PrintStream;Ljdk/internal/jshell/tool/PersistentStorage;Ljava/util/Map;Ljava/util/Locale;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printStackTrace", "([Ljava/lang/StackTraceElement;[Ljava/lang/StackTraceElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "(Ljdk/internal/jshell/tool/IOContext;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "version", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "version", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "start", "([Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prefix", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prefix", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indent", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getResource", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debug", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stop", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetState", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isActive", "(Ljdk/jshell/Snippet;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hard", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStart", "(Ljdk/internal/jshell/tool/ArgTokenizer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "commandCompletionSuggestions", "(Ljava/lang/String;I[I)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "commandDocumentation", "(Ljava/lang/String;IZ)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerCommand", "(Ljdk/internal/jshell/tool/JShellTool$Command;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "snippetCompletion", "(Ljava/util/function/Supplier;)Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "saveCompletion", "()Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCommand", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processCommand", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processSourceCatchingReset", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findCommand", "(Ljava/lang/String;Ljava/util/function/Predicate;)[Ljdk/internal/jshell/tool/JShellTool$Command;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processSource", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmdUseHistoryEntry", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rerunHistoryEntriesById", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fluffmsg", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addToReplayHistory", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "optionCompletion", "(Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;)Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "envCompletion", "()Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "reloadCompletion", "()Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "historyCompletion", "()Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "helpCompletion", "()Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "orMostSpecificCompletion", "(Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;)Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "skipWordThenCompletion", "(Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;)Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fileCompletions", "(Ljava/util/function/Predicate;)Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runFile", "(Ljava/lang/String;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initFeedback", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closeState", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkOptionsAndRemainingInput", "(Ljdk/internal/jshell/tool/ArgTokenizer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fluff", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmdHelp", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmdReset", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmdEnv", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmdExit", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmdImports", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "builtInEdit", "(Ljava/lang/String;Ljava/util/function/Consumer;Ljava/util/function/Consumer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmdHistory", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toPathResolvingUserHome", "(Ljava/lang/String;)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseCommandLineLikeFlags", "(Ljava/lang/String;Ljdk/internal/jshell/tool/JShellTool$OptionParserBase;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doReload", "(Ljdk/internal/jshell/tool/JShellTool$ReplayableHistory;ZLjdk/internal/jshell/tool/JShellTool$Options;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prefixError", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "showFluff", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hardmsg", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "configEditor", "()Ljdk/internal/jshell/tool/JShellTool$EditorSetting;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rerunSnippet", "(Ljdk/jshell/Snippet;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "displayEvalException", "(Ljdk/jshell/EvalException;[Ljava/lang/StackTraceElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "displayUnresolvedException", "(Ljdk/jshell/UnresolvedReferenceException;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printSnippetStatus", "(Ljdk/jshell/DeclarationSnippet;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "displayableDiagnostic", "(Ljava/lang/String;Ljdk/jshell/Diag;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allSnippets", "()Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropableSnippets", "()Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allVarSnippets", "()Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allMethodSnippets", "()Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allTypeSnippets", "()Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmdDebug", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nonEmptyStream", "(Ljava/util/function/Supplier;[Ljdk/internal/jshell/tool/JShellTool$SnippetPredicate;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mainActive", "(Ljdk/jshell/Snippet;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "snippetWithOptionCompletion", "(Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;Ljava/util/function/Supplier;)Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "displayDiagnostics", "(Ljava/lang/String;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "displayException", "(Ljava/lang/Throwable;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "displayException", "(Ljava/lang/Throwable;[Ljava/lang/StackTraceElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hardPairs", "(Ljava/util/stream/Stream;Ljava/util/function/Function;Ljava/util/function/Function;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hardrb", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inStartUp", "(Ljdk/jshell/Snippet;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "argsOptionsToSnippets", "(Ljava/util/function/Supplier;Ljava/util/function/Predicate;Ljdk/internal/jshell/tool/ArgTokenizer;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "argsOptionsToSnippets", "(Ljava/util/function/Supplier;Ljava/util/function/Predicate;Ljava/lang/String;Ljava/lang/String;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startUpRun", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFeedback", "(Ljdk/internal/jshell/tool/MessageHandler;Ljdk/internal/jshell/tool/ArgTokenizer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "errormsg", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processInput", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResourceString", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "errorsOnly", "(Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subCommand", "(Ljava/lang/String;Ljdk/internal/jshell/tool/ArgTokenizer;[Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "showIndent", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "showSetStart", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matchingDeclaration", "(Ljdk/jshell/Snippet;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmdDrop", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmdEdit", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmdOpen", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmdReload", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmdSave", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmdVars", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmdMethods", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmdTypes", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toAction", "(Ljdk/jshell/Snippet$Status;Ljdk/jshell/Snippet$Status;Z)Ljdk/internal/jshell/tool/Selector$FormatAction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "classPathCompletion", "()Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printUsage", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printUsageX", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "messageFormat", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isComplete", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmdList", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readResource", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "trimEnd", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fullVersion", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printHelp", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "interactive", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmdSet", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInput", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleEvent", "(Ljdk/jshell/SnippetEvent;)Z"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String PROMPT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String CONTINUATION_PROMPT_Property
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

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private static final")]
	public static Dova.JDK.java.util.regex.Pattern LINEBREAK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private static final")]
	public static Dova.JDK.java.util.regex.Pattern ID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private static final")]
	public static Dova.JDK.java.util.regex.Pattern RERUN_ID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private static final")]
	public static Dova.JDK.java.util.regex.Pattern RERUN_PREVIOUS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private static final")]
	public static Dova.JDK.java.util.regex.Pattern SET_SUB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String RECORD_SEPARATOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String RB_NAME_PREFIX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String VERSION_RB_NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String L10N_RB_NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/InputStream;", "final")]
	public Dova.JDK.java.io.InputStream cmdin_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/PrintStream;", "final")]
	public Dova.JDK.java.io.PrintStream cmdout_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/PrintStream;", "final")]
	public Dova.JDK.java.io.PrintStream cmderr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/PrintStream;", "final")]
	public Dova.JDK.java.io.PrintStream console_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/InputStream;", "final")]
	public Dova.JDK.java.io.InputStream userin_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/PrintStream;", "final")]
	public Dova.JDK.java.io.PrintStream userout_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/PrintStream;", "final")]
	public Dova.JDK.java.io.PrintStream usererr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/PersistentStorage;", "final")]
	public Dova.JDK.jdk.@internal.jshell.tool.PersistentStorage prefs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.PersistentStorage>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "final")]
	public Dova.JDK.java.util.Map envvars_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Locale;", "final")]
	public Dova.JDK.java.util.Locale locale_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "final")]
	public bool interactiveTerminal_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/Feedback;", "final")]
	public Dova.JDK.jdk.@internal.jshell.tool.Feedback feedback_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Feedback>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/ResourceBundle;", "private")]
	public Dova.JDK.java.util.ResourceBundle versionRB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ResourceBundle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/ResourceBundle;", "private")]
	public Dova.JDK.java.util.ResourceBundle outputRB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ResourceBundle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/IOContext;", "private")]
	public Dova.JDK.jdk.@internal.jshell.tool.IOContext input_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.IOContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool regenerateOnDeath_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool live_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[27]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[27], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool interactiveModeBegun_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$Options;", "private")]
	public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.Options options_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.Options>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jshell/SourceCodeAnalysis;", "")]
	public Dova.JDK.jdk.jshell.SourceCodeAnalysis analysis_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysis>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jshell/JShell;", "private")]
	public Dova.JDK.jdk.jshell.JShell state_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.JShell>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jshell/JShell$Subscription;", "")]
	public Dova.JDK.jdk.jshell.JShell.Subscription shutdownSubscription_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.JShell.Subscription>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$EditorSetting;", "static final")]
	public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.EditorSetting BUILT_IN_EDITOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.EditorSetting>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool debug_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[34]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[34], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int debugFlags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[35]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[35], value);
		}
	}

	[JniSignatureAttribute("Z", "public")]
	public bool testPrompt_Property
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

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/Startup;", "private")]
	public Dova.JDK.jdk.@internal.jshell.tool.Startup startup_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Startup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isCurrentlyRunningStartup_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String executionControlSpec_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$EditorSetting;", "private")]
	public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.EditorSetting editor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.EditorSetting>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int exitCode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[41]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[41], value);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> EDITOR_ENV_VARS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$ReplayableHistory;", "private")]
	public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.ReplayableHistory replayableHistory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.ReplayableHistory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$ReplayableHistory;", "private")]
	public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.ReplayableHistory replayableHistoryPrevious_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[44]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.ReplayableHistory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String STARTUP_KEY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String EDITOR_KEY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String MODE_KEY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String MODE2_KEY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String FEEDBACK_KEY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String REPLAY_RESTORE_KEY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String INDENT_KEY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "static final")]
	public static Dova.JDK.java.util.regex.Pattern BUILTIN_FILE_PATTERN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String BUILTIN_FILE_PATH_FORMAT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String INT_PREFIX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int OUTPUT_WIDTH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[55]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[55], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int DEFAULT_INDENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[56]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[56], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private static final")]
	public static Dova.JDK.java.util.regex.Pattern OPTION_PRE_PATTERN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private static final")]
	public static Dova.JDK.java.util.regex.Pattern OPTION_PATTERN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private static final")]
	public static Dova.JDK.java.util.regex.Pattern OPTION_VALUE_PATTERN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$NameSpace;", "")]
	public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.NameSpace mainNamespace_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[60]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.NameSpace>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[60], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$NameSpace;", "")]
	public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.NameSpace startNamespace_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[61]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.NameSpace>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[61], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$NameSpace;", "")]
	public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.NameSpace errorNamespace_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[62]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.NameSpace>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[62], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$NameSpace;", "")]
	public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.NameSpace currentNameSpace_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[63]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.NameSpace>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[63], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map mapSnippet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[64]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[64], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "static final")]
	public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider EMPTY_COMPLETION_PROVIDER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "private static final")]
	public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider SNIPPET_HISTORY_OPTION_COMPLETION_PROVIDER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "private static final")]
	public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider SAVE_OPTION_COMPLETION_PROVIDER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "private static final")]
	public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider HISTORY_OPTION_COMPLETION_PROVIDER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[68]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[68], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "private static final")]
	public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider SNIPPET_OPTION_COMPLETION_PROVIDER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[69]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[69], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$FixedCompletionProvider;", "private static final")]
	public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.FixedCompletionProvider COMMAND_LINE_LIKE_OPTIONS_COMPLETION_PROVIDER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.FixedCompletionProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "private static final")]
	public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider RELOAD_OPTIONS_COMPLETION_PROVIDER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[71]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[71], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "private static final")]
	public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider SET_MODE_OPTIONS_COMPLETION_PROVIDER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[72]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[72], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "private static final")]
	public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider FILE_COMPLETION_PROVIDER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[73]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[73], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map ARG_OPTIONS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[74]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[74], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map commands_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[75]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[75], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/ContinuousCompletionProvider;", "private")]
	public Dova.JDK.jdk.@internal.jshell.tool.ContinuousCompletionProvider commandCompletions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[76]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ContinuousCompletionProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[76], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> SET_SUBCOMMANDS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[77]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[77], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[78]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[78], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JShellTool(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/io/PrintStream;Ljava/io/PrintStream;Ljava/io/PrintStream;Ljava/io/InputStream;Ljava/io/PrintStream;Ljava/io/PrintStream;Ljdk/internal/jshell/tool/PersistentStorage;Ljava/util/Map;Ljava/util/Locale;Z)V", "")]
	public JShellTool(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.io.PrintStream arg1, Dova.JDK.java.io.PrintStream arg2, Dova.JDK.java.io.PrintStream arg3, Dova.JDK.java.io.InputStream arg4, Dova.JDK.java.io.PrintStream arg5, Dova.JDK.java.io.PrintStream arg6, Dova.JDK.jdk.@internal.jshell.tool.PersistentStorage arg7, Dova.JDK.java.util.Map arg8, Dova.JDK.java.util.Locale arg9, bool arg10) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/JShellTool;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljava/lang/StackTraceElement;[Ljava/lang/StackTraceElement;)V", "")]
	public void printStackTrace(JavaArray<Dova.JDK.java.lang.StackTraceElement> arg0, JavaArray<Dova.JDK.java.lang.StackTraceElement> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/IOContext;)Z", "private")]
	public bool run(Dova.JDK.jdk.@internal.jshell.tool.IOContext arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String version(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String version()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)I", "public")]
	public int start(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String prefix(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String prefix(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String indent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String getResource(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "transient")]
	public void debug(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "")]
	public void stop()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void resetState()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "transient")]
	public void error(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/jshell/Snippet;)Z", "private")]
	public bool isActive(Dova.JDK.jdk.jshell.Snippet arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "public transient")]
	public void hard(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/ArgTokenizer;)Z", "")]
	public bool setStart(Dova.JDK.jdk.@internal.jshell.tool.ArgTokenizer arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I[I)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List commandCompletionSuggestions(Dova.JDK.java.lang.String arg0, int arg1, JavaArray<int> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;IZ)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List commandDocumentation(Dova.JDK.java.lang.String arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool$Command;)V", "private")]
	public void registerCommand(Dova.JDK.jdk.@internal.jshell.tool.JShellTool.Command arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;)Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "private")]
	public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider snippetCompletion(Dova.JDK.java.util.function.Supplier arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "private static")]
	public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider saveCompletion()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool isCommand(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
	public void processCommand(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool processSourceCatchingReset(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/function/Predicate;)[Ljdk/internal/jshell/tool/JShellTool$Command;", "private")]
	public JavaArray<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.Command> findCommand(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.function.Predicate arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.Command>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "")]
	public bool processSource(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "private")]
	public bool cmdUseHistoryEntry(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
	public void rerunHistoryEntriesById(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "public transient")]
	public void fluffmsg(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
	public void addToReplayHistory(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;)Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "private static")]
	public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider optionCompletion(Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "private static")]
	public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider envCompletion()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "private static")]
	public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider reloadCompletion()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "private static")]
	public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider historyCompletion()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "private")]
	public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider helpCompletion()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;)Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "private static")]
	public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider orMostSpecificCompletion(Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider arg0, Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;)Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "private static")]
	public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider skipWordThenCompletion(Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;)Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "private static")]
	public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider fileCompletions(Dova.JDK.java.util.function.Predicate arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Z", "private")]
	public bool runFile(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
	public void initFeedback(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void closeState()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40]);
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/ArgTokenizer;)Z", "")]
	public bool checkOptionsAndRemainingInput(Dova.JDK.jdk.@internal.jshell.tool.ArgTokenizer arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "public transient")]
	public void fluff(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "")]
	public bool cmdHelp(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool cmdReset(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool cmdEnv(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool cmdExit(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool cmdImports()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[47]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/function/Consumer;Ljava/util/function/Consumer;)Z", "private")]
	public bool builtInEdit(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.function.Consumer arg1, Dova.JDK.java.util.function.Consumer arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool cmdHistory(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/nio/file/Path;", "static")]
	public static Dova.JDK.java.nio.file.Path toPathResolvingUserHome(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[50], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljdk/internal/jshell/tool/JShellTool$OptionParserBase;)Z", "private")]
	public bool parseCommandLineLikeFlags(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionParserBase arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool$ReplayableHistory;ZLjdk/internal/jshell/tool/JShellTool$Options;)Z", "private")]
	public bool doReload(Dova.JDK.jdk.@internal.jshell.tool.JShellTool.ReplayableHistory arg0, bool arg1, Dova.JDK.jdk.@internal.jshell.tool.JShellTool.Options arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String prefixError(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool showFluff()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[54]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "public transient")]
	public void hardmsg(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljdk/internal/jshell/tool/JShellTool$EditorSetting;", "private")]
	public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.EditorSetting configEditor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.EditorSetting>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/Snippet;)V", "private")]
	public void rerunSnippet(Dova.JDK.jdk.jshell.Snippet arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
	}

	[JniSignatureAttribute("(Ljdk/jshell/EvalException;[Ljava/lang/StackTraceElement;)Z", "private")]
	public bool displayEvalException(Dova.JDK.jdk.jshell.EvalException arg0, JavaArray<Dova.JDK.java.lang.StackTraceElement> arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/jshell/UnresolvedReferenceException;)Z", "private")]
	public bool displayUnresolvedException(Dova.JDK.jdk.jshell.UnresolvedReferenceException arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/jshell/DeclarationSnippet;Z)V", "")]
	public void printSnippetStatus(Dova.JDK.jdk.jshell.DeclarationSnippet arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljdk/jshell/Diag;Ljava/util/List;)V", "private")]
	public void displayableDiagnostic(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.jshell.Diag arg1, Dova.JDK.java.util.List arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Stream;", "")]
	public Dova.JDK.java.util.stream.Stream allSnippets()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Stream;", "")]
	public Dova.JDK.java.util.stream.Stream dropableSnippets()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Stream;", "")]
	public Dova.JDK.java.util.stream.Stream allVarSnippets()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Stream;", "")]
	public Dova.JDK.java.util.stream.Stream allMethodSnippets()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Stream;", "")]
	public Dova.JDK.java.util.stream.Stream allTypeSnippets()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "")]
	public bool cmdDebug(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[67], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;[Ljdk/internal/jshell/tool/JShellTool$SnippetPredicate;)Ljava/util/stream/Stream;", "private static transient")]
	public static Dova.JDK.java.util.stream.Stream nonEmptyStream(Dova.JDK.java.util.function.Supplier arg0, JavaArray<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.SnippetPredicate> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[68], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/Snippet;)Z", "private")]
	public bool mainActive(Dova.JDK.jdk.jshell.Snippet arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[69], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;Ljava/util/function/Supplier;)Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "private")]
	public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider snippetWithOptionCompletion(Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider arg0, Dova.JDK.java.util.function.Supplier arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/List;)V", "private")]
	public void displayDiagnostics(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.List arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[71], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)Z", "private")]
	public bool displayException(Dova.JDK.java.lang.Throwable arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[72], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;[Ljava/lang/StackTraceElement;)Z", "private")]
	public bool displayException(Dova.JDK.java.lang.Throwable arg0, JavaArray<Dova.JDK.java.lang.StackTraceElement> arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[73], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/stream/Stream;Ljava/util/function/Function;Ljava/util/function/Function;)V", "")]
	public void hardPairs(Dova.JDK.java.util.stream.Stream arg0, Dova.JDK.java.util.function.Function arg1, Dova.JDK.java.util.function.Function arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[74], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
	public void hardrb(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[75], arg0);
	}

	[JniSignatureAttribute("(Ljdk/jshell/Snippet;)Z", "private")]
	public bool inStartUp(Dova.JDK.jdk.jshell.Snippet arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[76], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;Ljava/util/function/Predicate;Ljdk/internal/jshell/tool/ArgTokenizer;)Ljava/util/stream/Stream;", "private")]
	public Dova.JDK.java.util.stream.Stream argsOptionsToSnippets(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.java.util.function.Predicate arg1, Dova.JDK.jdk.@internal.jshell.tool.ArgTokenizer arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;Ljava/util/function/Predicate;Ljava/lang/String;Ljava/lang/String;)Ljava/util/stream/Stream;", "private")]
	public Dova.JDK.java.util.stream.Stream argsOptionsToSnippets(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.java.util.function.Predicate arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
	public void startUpRun(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[79], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/MessageHandler;Ljdk/internal/jshell/tool/ArgTokenizer;)Z", "")]
	public bool setFeedback(Dova.JDK.jdk.@internal.jshell.tool.MessageHandler arg0, Dova.JDK.jdk.@internal.jshell.tool.ArgTokenizer arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[80], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "public transient")]
	public void errormsg(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[81], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String processInput(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[82], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getResourceString(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[83], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/util/List;", "")]
	public Dova.JDK.java.util.List errorsOnly(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[84], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljdk/internal/jshell/tool/ArgTokenizer;[Ljava/lang/String;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String subCommand(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.@internal.jshell.tool.ArgTokenizer arg1, JavaArray<Dova.JDK.java.lang.String> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[85], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void showIndent()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[86]);
	}

	[JniSignatureAttribute("()V", "")]
	public void showSetStart()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[87]);
	}

	[JniSignatureAttribute("(Ljdk/jshell/Snippet;Ljava/lang/String;)Z", "private")]
	public bool matchingDeclaration(Dova.JDK.jdk.jshell.Snippet arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[88], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool cmdDrop(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[89], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool cmdEdit(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[90], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool cmdOpen(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[91], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool cmdReload(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[92], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool cmdSave(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[93], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool cmdVars(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[94], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool cmdMethods(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[95], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool cmdTypes(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[96], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/jshell/Snippet$Status;Ljdk/jshell/Snippet$Status;Z)Ljdk/internal/jshell/tool/Selector$FormatAction;", "private")]
	public Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction toAction(Dova.JDK.jdk.jshell.Snippet.Status arg0, Dova.JDK.jdk.jshell.Snippet.Status arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[97], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "private static")]
	public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider classPathCompletion()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[98]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void printUsage()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[99]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void printUsageX()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[100]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", "transient")]
	public Dova.JDK.java.lang.String messageFormat(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[101], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool isComplete(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[102], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool cmdList(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[103], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String readResource(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[104], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String trimEnd(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[105], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String fullVersion()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[106]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "private")]
	public void printHelp(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[107], arg0, arg1);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool interactive()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[108]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "final")]
	public bool cmdSet(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[109], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getInput(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[110], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/SnippetEvent;)Z", "private")]
	public bool handleEvent(Dova.JDK.jdk.jshell.SnippetEvent arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[111], arg0);
		return ret;
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$EditorSetting;", "static")]
	public partial class EditorSetting
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EditorSetting()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/JShellTool$EditorSetting;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BUILT_IN_REP", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WAIT_PREFIX", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NORMAL_PREFIX", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cmd", "[Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "wait", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/String;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromPrefs", "(Ljdk/internal/jshell/tool/PersistentStorage;)Ljdk/internal/jshell/tool/JShellTool$EditorSetting;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removePrefs", "(Ljdk/internal/jshell/tool/PersistentStorage;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toPrefs", "(Ljdk/internal/jshell/tool/PersistentStorage;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "static")]
		public static Dova.JDK.java.lang.String BUILT_IN_REP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("C", "static")]
		public static char WAIT_PREFIX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("C", "static")]
		public static char NORMAL_PREFIX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/String;", "final")]
		public JavaArray<Dova.JDK.java.lang.String> cmd_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "final")]
		public bool wait_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EditorSetting(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Ljava/lang/String;Z)V", "")]
		public EditorSetting(JavaArray<Dova.JDK.java.lang.String> arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/JShellTool$EditorSetting;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/PersistentStorage;)Ljdk/internal/jshell/tool/JShellTool$EditorSetting;", "static")]
		public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.EditorSetting fromPrefs(Dova.JDK.jdk.@internal.jshell.tool.PersistentStorage arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.EditorSetting>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/PersistentStorage;)V", "static")]
		public static void removePrefs(Dova.JDK.jdk.@internal.jshell.tool.PersistentStorage arg0)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/PersistentStorage;)V", "")]
		public void toPrefs(Dova.JDK.jdk.@internal.jshell.tool.PersistentStorage arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$Command;", "static final")]
	public partial class Command
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Command()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/JShellTool$Command;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "command", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "helpKey", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "run", "Ljava/util/function/Function;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "completions", "Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kind", "Ljdk/internal/jshell/tool/JShellTool$CommandKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/function/Function;Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;Ljdk/internal/jshell/tool/JShellTool$CommandKind;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljdk/internal/jshell/tool/JShellTool$CommandKind;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/util/function/Function;Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;Ljdk/internal/jshell/tool/JShellTool$CommandKind;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/util/function/Function;Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String command_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String helpKey_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/Function;", "public final")]
		public Dova.JDK.java.util.function.Function run_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "public final")]
		public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider completions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$CommandKind;", "public final")]
		public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind kind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Command(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/util/function/Function;Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;Ljdk/internal/jshell/tool/JShellTool$CommandKind;)V", "public")]
		public Command(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.function.Function arg2, Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider arg3, Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljdk/internal/jshell/tool/JShellTool$CommandKind;)V", "public")]
		public Command(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/function/Function;Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;Ljdk/internal/jshell/tool/JShellTool$CommandKind;)V", "public")]
		public Command(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.function.Function arg1, Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider arg2, Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/function/Function;Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;)V", "public")]
		public Command(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.function.Function arg1, Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/JShellTool$Command;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "abstract static interface")]
	public partial interface CompletionProvider
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CompletionProvider()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "completionSuggestions", "(Ljava/lang/String;I[I)Ljava/util/List;"));
		}

		[JniSignatureAttribute("(Ljava/lang/String;I[I)Ljava/util/List;", "public abstract")]
		Dova.JDK.java.util.List completionSuggestions(Dova.JDK.java.lang.String arg0, int arg1, JavaArray<int> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$CommandKind;", "static final")]
	public partial class CommandKind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CommandKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/JShellTool$CommandKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NORMAL", "Ljdk/internal/jshell/tool/JShellTool$CommandKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REPLAY", "Ljdk/internal/jshell/tool/JShellTool$CommandKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HIDDEN", "Ljdk/internal/jshell/tool/JShellTool$CommandKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HELP_ONLY", "Ljdk/internal/jshell/tool/JShellTool$CommandKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HELP_SUBJECT", "Ljdk/internal/jshell/tool/JShellTool$CommandKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isRealCommand", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "showInHelp", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shouldSuggestCompletions", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/jshell/tool/JShellTool$CommandKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IZZZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/jshell/tool/JShellTool$CommandKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/jshell/tool/JShellTool$CommandKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/jshell/tool/JShellTool$CommandKind;"));
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$CommandKind;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind NORMAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$CommandKind;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind REPLAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$CommandKind;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind HIDDEN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$CommandKind;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind HELP_ONLY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$CommandKind;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind HELP_SUBJECT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "final")]
		public bool isRealCommand_Property
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

		[JniSignatureAttribute("Z", "final")]
		public bool showInHelp_Property
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

		[JniSignatureAttribute("Z", "final")]
		public bool shouldSuggestCompletions_Property
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

		[JniSignatureAttribute("[Ljdk/internal/jshell/tool/JShellTool$CommandKind;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CommandKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;IZZZ)V", "private")]
		public CommandKind(Dova.JDK.java.lang.String arg0, int arg1, bool arg2, bool arg3, bool arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/JShellTool$CommandKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/jshell/tool/JShellTool$CommandKind;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jshell/tool/JShellTool$CommandKind;", "public static")]
		public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/jshell/tool/JShellTool$CommandKind;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CommandKind>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$OptionParserCommandLine;", "private")]
	public partial class OptionParserCommandLine
		: Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionParserBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OptionParserCommandLine()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/JShellTool$OptionParserCommandLine;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argStart", "Ljdk/internal/joptsimple/OptionSpec;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argNoStart", "Ljdk/internal/joptsimple/OptionSpecBuilder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argFeedback", "Ljdk/internal/joptsimple/OptionSpec;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argExecution", "Ljdk/internal/joptsimple/OptionSpec;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argQ", "Ljdk/internal/joptsimple/OptionSpecBuilder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argS", "Ljdk/internal/joptsimple/OptionSpecBuilder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argV", "Ljdk/internal/joptsimple/OptionSpecBuilder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argR", "Ljdk/internal/joptsimple/OptionSpec;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argC", "Ljdk/internal/joptsimple/OptionSpec;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argHelp", "Ljdk/internal/joptsimple/OptionSpecBuilder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argVersion", "Ljdk/internal/joptsimple/OptionSpecBuilder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argFullVersion", "Ljdk/internal/joptsimple/OptionSpecBuilder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argShowVersion", "Ljdk/internal/joptsimple/OptionSpecBuilder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argHelpExtra", "Ljdk/internal/joptsimple/OptionSpecBuilder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "feedbackMode", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initialStartup", "Ljdk/internal/jshell/tool/Startup;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/jshell/tool/JShellTool;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/JShellTool;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "msg", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljdk/internal/joptsimple/OptionSet;)Ljdk/internal/jshell/tool/JShellTool$Options;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "feedbackMode", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startup", "()Ljdk/internal/jshell/tool/Startup;"));
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpec;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpec argStart_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpec>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpecBuilder;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder argNoStart_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpec;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpec argFeedback_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpec>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpec;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpec argExecution_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpec>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpecBuilder;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder argQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpecBuilder;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder argS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpecBuilder;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder argV_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpec;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpec argR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpec>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpec;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpec argC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpec>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpecBuilder;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder argHelp_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpecBuilder;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder argVersion_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpecBuilder;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder argFullVersion_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpecBuilder;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder argShowVersion_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpecBuilder;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder argHelpExtra_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String feedbackMode_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Startup;", "private")]
		public Dova.JDK.jdk.@internal.jshell.tool.Startup initialStartup_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Startup>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool;", "final")]
		public Dova.JDK.jdk.@internal.jshell.tool.JShellTool this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OptionParserCommandLine(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool;)V", "private")]
		public OptionParserCommandLine(Dova.JDK.jdk.@internal.jshell.tool.JShellTool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/JShellTool$OptionParserCommandLine;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "transient")]
		public void msg(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljdk/internal/joptsimple/OptionSet;)Ljdk/internal/jshell/tool/JShellTool$Options;", "")]
		public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.Options parse(Dova.JDK.jdk.@internal.joptsimple.OptionSet arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.Options>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String feedbackMode()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljdk/internal/jshell/tool/Startup;", "")]
		public Dova.JDK.jdk.@internal.jshell.tool.Startup startup()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Startup>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$Options;", "private static")]
	public partial class Options
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Options()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/JShellTool$Options;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "optMap", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/JShellTool$Options;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAll", "(Ljdk/internal/jshell/tool/JShellTool$OptionKind;Ljava/util/Collection;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "override", "(Ljdk/internal/jshell/tool/JShellTool$Options;)Ljdk/internal/jshell/tool/JShellTool$Options;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shownOptions", "()[Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remoteVmOptions", "()[Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selectOptions", "(Ljava/util/function/Predicate;)[Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compilerOptions", "()[Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map optMap_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Options(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Options() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool$Options;)V", "private")]
		public Options(Dova.JDK.jdk.@internal.jshell.tool.JShellTool.Options arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/JShellTool$Options;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool$OptionKind;Ljava/util/Collection;)V", "")]
		public void addAll(Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind arg0, Dova.JDK.java.util.Collection arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool$Options;)Ljdk/internal/jshell/tool/JShellTool$Options;", "")]
		public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.Options @override(Dova.JDK.jdk.@internal.jshell.tool.JShellTool.Options arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.Options>(ret);
		}

		[JniSignatureAttribute("()[Ljava/lang/String;", "")]
		public JavaArray<Dova.JDK.java.lang.String> shownOptions()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}

		[JniSignatureAttribute("()[Ljava/lang/String;", "")]
		public JavaArray<Dova.JDK.java.lang.String> remoteVmOptions()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Predicate;)[Ljava/lang/String;", "private")]
		public JavaArray<Dova.JDK.java.lang.String> selectOptions(Dova.JDK.java.util.function.Predicate arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}

		[JniSignatureAttribute("()[Ljava/lang/String;", "")]
		public JavaArray<Dova.JDK.java.lang.String> compilerOptions()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$ReplayableHistory;", "private static")]
	public partial class ReplayableHistory
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ReplayableHistory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/JShellTool$ReplayableHistory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hist", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastSaved", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "storeHistory", "(Ljdk/internal/jshell/tool/PersistentStorage;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "emptyHistory", "()Ljdk/internal/jshell/tool/JShellTool$ReplayableHistory;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromPrevious", "(Ljdk/internal/jshell/tool/PersistentStorage;)Ljdk/internal/jshell/tool/JShellTool$ReplayableHistory;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "markSaved", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterable", "()Ljava/lang/Iterable;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private")]
		public Dova.JDK.java.util.List hist_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int lastSaved_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ReplayableHistory(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "private")]
		public ReplayableHistory(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/JShellTool$ReplayableHistory;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
		public void add(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/PersistentStorage;)V", "")]
		public void storeHistory(Dova.JDK.jdk.@internal.jshell.tool.PersistentStorage arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Ljdk/internal/jshell/tool/JShellTool$ReplayableHistory;", "static")]
		public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.ReplayableHistory emptyHistory()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.ReplayableHistory>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/PersistentStorage;)Ljdk/internal/jshell/tool/JShellTool$ReplayableHistory;", "static")]
		public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.ReplayableHistory fromPrevious(Dova.JDK.jdk.@internal.jshell.tool.PersistentStorage arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.ReplayableHistory>(ret);
		}

		[JniSignatureAttribute("()V", "")]
		public void markSaved()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("()Ljava/lang/Iterable;", "")]
		public Dova.JDK.java.lang.Iterable iterable()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$NameSpace;", "")]
	public partial class NameSpace
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NameSpace()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/JShellTool$NameSpace;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "spaceName", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prefix", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextNum", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/jshell/tool/JShellTool;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/JShellTool;Ljava/lang/String;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tid", "(Ljdk/jshell/Snippet;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tidNext", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String spaceName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String prefix_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int nextNum_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool;", "final")]
		public Dova.JDK.jdk.@internal.jshell.tool.JShellTool this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NameSpace(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public NameSpace(Dova.JDK.jdk.@internal.jshell.tool.JShellTool arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/JShellTool$NameSpace;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/jshell/Snippet;)Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String tid(Dova.JDK.jdk.jshell.Snippet arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String tidNext()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$InitMessageHandler;", "private")]
	public partial class InitMessageHandler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.jshell.tool.MessageHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InitMessageHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/JShellTool$InitMessageHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/jshell/tool/JShellTool;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/JShellTool;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hard", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fluffmsg", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fluff", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "showFluff", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hardmsg", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "errormsg", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool;", "final")]
		public Dova.JDK.jdk.@internal.jshell.tool.JShellTool this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InitMessageHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool;)V", "private")]
		public InitMessageHandler(Dova.JDK.jdk.@internal.jshell.tool.JShellTool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/JShellTool$InitMessageHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "public transient")]
		public void hard(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "public transient")]
		public void fluffmsg(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "public transient")]
		public void fluff(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool showFluff()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "public transient")]
		public void hardmsg(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "public transient")]
		public void errormsg(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$FixedCompletionProvider;", "static final")]
	public partial class FixedCompletionProvider
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FixedCompletionProvider()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/JShellTool$FixedCompletionProvider;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "alternatives", "[Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/String;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/JShellTool$FixedCompletionProvider;[Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "completionSuggestions", "(Ljava/lang/String;I[I)Ljava/util/List;"));
		}

		[JniSignatureAttribute("[Ljava/lang/String;", "private final")]
		public JavaArray<Dova.JDK.java.lang.String> alternatives_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FixedCompletionProvider(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Ljava/lang/String;)V", "public transient")]
		public FixedCompletionProvider(JavaArray<Dova.JDK.java.lang.String> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool$FixedCompletionProvider;[Ljava/lang/String;)V", "public transient")]
		public FixedCompletionProvider(Dova.JDK.jdk.@internal.jshell.tool.JShellTool.FixedCompletionProvider arg0, JavaArray<Dova.JDK.java.lang.String> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/JShellTool$FixedCompletionProvider;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;I[I)Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List completionSuggestions(Dova.JDK.java.lang.String arg0, int arg1, JavaArray<int> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$SetEditor;", "")]
	public partial class SetEditor
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SetEditor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/JShellTool$SetEditor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "at", "Ljdk/internal/jshell/tool/ArgTokenizer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "command", "[Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hasCommand", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultOption", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "deleteOption", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "waitOption", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "retainOption", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "primaryOptionCount", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/jshell/tool/JShellTool;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/JShellTool;Ljdk/internal/jshell/tool/ArgTokenizer;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/JShellTool;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljdk/internal/jshell/tool/JShellTool$EditorSetting;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "check", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "install", "()V"));
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/ArgTokenizer;", "private final")]
		public Dova.JDK.jdk.@internal.jshell.tool.ArgTokenizer at_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ArgTokenizer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/String;", "private final")]
		public JavaArray<Dova.JDK.java.lang.String> command_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool hasCommand_Property
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
		public bool defaultOption_Property
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
		public bool deleteOption_Property
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
		public bool waitOption_Property
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
		public bool retainOption_Property
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

		[JniSignatureAttribute("I", "private final")]
		public int primaryOptionCount_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool;", "final")]
		public Dova.JDK.jdk.@internal.jshell.tool.JShellTool this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SetEditor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool;Ljdk/internal/jshell/tool/ArgTokenizer;)V", "")]
		public SetEditor(Dova.JDK.jdk.@internal.jshell.tool.JShellTool arg0, Dova.JDK.jdk.@internal.jshell.tool.ArgTokenizer arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool;)V", "")]
		public SetEditor(Dova.JDK.jdk.@internal.jshell.tool.JShellTool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/JShellTool$SetEditor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool$EditorSetting;)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String format(Dova.JDK.jdk.@internal.jshell.tool.JShellTool.EditorSetting arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool set()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "private")]
		public bool check()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()V", "private")]
		public void install()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$SnippetInfo;", "static")]
	public partial class SnippetInfo
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SnippetInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/JShellTool$SnippetInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "snippet", "Ljdk/jshell/Snippet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "space", "Ljdk/internal/jshell/tool/JShellTool$NameSpace;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tid", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/jshell/Snippet;Ljdk/internal/jshell/tool/JShellTool$NameSpace;Ljava/lang/String;)V"));
		}

		[JniSignatureAttribute("Ljdk/jshell/Snippet;", "final")]
		public Dova.JDK.jdk.jshell.Snippet snippet_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.Snippet>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$NameSpace;", "final")]
		public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.NameSpace space_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.NameSpace>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String tid_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SnippetInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/jshell/Snippet;Ljdk/internal/jshell/tool/JShellTool$NameSpace;Ljava/lang/String;)V", "")]
		public SnippetInfo(Dova.JDK.jdk.jshell.Snippet arg0, Dova.JDK.jdk.@internal.jshell.tool.JShellTool.NameSpace arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/JShellTool$SnippetInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$ArgToSnippets;", "private")]
	public partial class ArgToSnippets
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ArgToSnippets()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/JShellTool$ArgToSnippets;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "snippetSupplier", "Ljava/util/function/Supplier;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allSnippets", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allIds", "[Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/jshell/tool/JShellTool;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/JShellTool;Ljava/util/function/Supplier;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "range", "(Ljava/lang/String;)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "order", "(Ljdk/jshell/Snippet;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "order", "(Ljava/lang/String;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "argsToSnippets", "(Ljava/util/List;)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allIds", "()[Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "argToSnippets", "(Ljava/lang/String;)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layeredSnippetSearch", "(Ljava/util/function/Supplier;Ljava/lang/String;)Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "badSnippetErrormsg", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "snippetIndex", "(Ljava/lang/String;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initIdMapping", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/function/Supplier;", "final")]
		public Dova.JDK.java.util.function.Supplier snippetSupplier_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Supplier>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "")]
		public Dova.JDK.java.util.List allSnippets_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/String;", "")]
		public JavaArray<Dova.JDK.java.lang.String> allIds_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool;", "final")]
		public Dova.JDK.jdk.@internal.jshell.tool.JShellTool this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ArgToSnippets(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool;Ljava/util/function/Supplier;)V", "")]
		public ArgToSnippets(Dova.JDK.jdk.@internal.jshell.tool.JShellTool arg0, Dova.JDK.java.util.function.Supplier arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/JShellTool$ArgToSnippets;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/stream/Stream;", "")]
		public Dova.JDK.java.util.stream.Stream range(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(Ljdk/jshell/Snippet;)I", "")]
		public int order(Dova.JDK.jdk.jshell.Snippet arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)I", "")]
		public int order(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/List;)Ljava/util/stream/Stream;", "")]
		public Dova.JDK.java.util.stream.Stream argsToSnippets(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("()[Ljava/lang/String;", "")]
		public JavaArray<Dova.JDK.java.lang.String> allIds()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/stream/Stream;", "")]
		public Dova.JDK.java.util.stream.Stream argToSnippets(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Supplier;Ljava/lang/String;)Ljava/util/stream/Stream;", "")]
		public Dova.JDK.java.util.stream.Stream layeredSnippetSearch(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
		public void badSnippetErrormsg(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)I", "")]
		public int snippetIndex(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return ret;
		}

		[JniSignatureAttribute("()V", "")]
		public void initIdMapping()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$SaveHandler;", "private")]
	public partial class SaveHandler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.function.Consumer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SaveHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/JShellTool$SaveHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "src", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currSrcs", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/jshell/tool/JShellTool;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/JShellTool;Ljava/lang/String;Ljava/util/Set;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trimNewlines", "(Ljava/lang/String;)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String src_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "")]
		public Dova.JDK.java.util.Set currSrcs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool;", "final")]
		public Dova.JDK.jdk.@internal.jshell.tool.JShellTool this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SaveHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool;Ljava/lang/String;Ljava/util/Set;)V", "")]
		public SaveHandler(Dova.JDK.jdk.@internal.jshell.tool.JShellTool arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Set arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/JShellTool$SaveHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void accept(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void accept(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String trimNewlines(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$OptionParserBase;", "private")]
	public partial class OptionParserBase
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OptionParserBase()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/JShellTool$OptionParserBase;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parser", "Ljdk/internal/joptsimple/OptionParser;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argClassPath", "Ljdk/internal/joptsimple/OptionSpec;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argModulePath", "Ljdk/internal/joptsimple/OptionSpec;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argAddModules", "Ljdk/internal/joptsimple/OptionSpec;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argAddExports", "Ljdk/internal/joptsimple/OptionSpec;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argEnablePreview", "Ljdk/internal/joptsimple/OptionSpecBuilder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argEnableNativeAccess", "Ljdk/internal/joptsimple/OptionSpecBuilder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argNonOptions", "Ljdk/internal/joptsimple/NonOptionArgumentSpec;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "opts", "Ljdk/internal/jshell/tool/JShellTool$Options;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nonOptions", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "failed", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/jshell/tool/JShellTool;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/JShellTool;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "msg", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljdk/internal/joptsimple/OptionSet;)Ljdk/internal/jshell/tool/JShellTool$Options;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "([Ljava/lang/String;)Ljdk/internal/jshell/tool/JShellTool$Options;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nonOptions", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validPaths", "(Ljava/util/Collection;Ljava/lang/String;Z)Ljava/util/Collection;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addOptions", "(Ljdk/internal/jshell/tool/JShellTool$OptionKind;Ljava/util/Collection;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkValidPathEntry", "(Ljava/nio/file/Path;Ljava/lang/String;Z)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toPathImpl", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/stream/Stream;"));
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionParser;", "final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionParser parser_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionParser>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpec;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpec argClassPath_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpec>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpec;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpec argModulePath_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpec>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpec;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpec argAddModules_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpec>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpec;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpec argAddExports_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpec>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpecBuilder;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder argEnablePreview_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpecBuilder;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder argEnableNativeAccess_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/NonOptionArgumentSpec;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.NonOptionArgumentSpec argNonOptions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.NonOptionArgumentSpec>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$Options;", "private")]
		public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.Options opts_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.Options>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "private")]
		public Dova.JDK.java.util.List nonOptions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool failed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[10]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[10], value);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool;", "final")]
		public Dova.JDK.jdk.@internal.jshell.tool.JShellTool this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OptionParserBase(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool;)V", "private")]
		public OptionParserBase(Dova.JDK.jdk.@internal.jshell.tool.JShellTool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/JShellTool$OptionParserBase;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "transient")]
		public void msg(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljdk/internal/joptsimple/OptionSet;)Ljdk/internal/jshell/tool/JShellTool$Options;", "")]
		public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.Options parse(Dova.JDK.jdk.@internal.joptsimple.OptionSet arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.Options>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/String;)Ljdk/internal/jshell/tool/JShellTool$Options;", "")]
		public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.Options parse(JavaArray<Dova.JDK.java.lang.String> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.Options>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "")]
		public Dova.JDK.java.util.List nonOptions()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;Ljava/lang/String;Z)Ljava/util/Collection;", "private")]
		public Dova.JDK.java.util.Collection validPaths(Dova.JDK.java.util.Collection arg0, Dova.JDK.java.lang.String arg1, bool arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool$OptionKind;Ljava/util/Collection;)V", "")]
		public void addOptions(Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind arg0, Dova.JDK.java.util.Collection arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/String;Z)Z", "private")]
		public bool checkValidPathEntry(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.String arg1, bool arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/util/stream/Stream;", "private")]
		public Dova.JDK.java.util.stream.Stream toPathImpl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$OptionParserReload;", "private")]
	public partial class OptionParserReload
		: Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionParserBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OptionParserReload()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/JShellTool$OptionParserReload;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argRestore", "Ljdk/internal/joptsimple/OptionSpecBuilder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argQuiet", "Ljdk/internal/joptsimple/OptionSpecBuilder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "restore", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "quiet", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/JShellTool;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljdk/internal/joptsimple/OptionSet;)Ljdk/internal/jshell/tool/JShellTool$Options;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "quiet", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "restore", "()Z"));
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpecBuilder;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder argRestore_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/joptsimple/OptionSpecBuilder;", "private final")]
		public Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder argQuiet_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.joptsimple.OptionSpecBuilder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool restore_Property
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

		[JniSignatureAttribute("Z", "private")]
		public bool quiet_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OptionParserReload(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool;)V", "private")]
		public OptionParserReload(Dova.JDK.jdk.@internal.jshell.tool.JShellTool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/JShellTool$OptionParserReload;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/internal/joptsimple/OptionSet;)Ljdk/internal/jshell/tool/JShellTool$Options;", "")]
		public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.Options parse(Dova.JDK.jdk.@internal.joptsimple.OptionSet arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.Options>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool quiet()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool restore()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$DisplayEvent;", "")]
	public partial class DisplayEvent
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DisplayEvent()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/JShellTool$DisplayEvent;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sn", "Ljdk/jshell/Snippet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "action", "Ljdk/internal/jshell/tool/Selector$FormatAction;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "update", "Ljdk/internal/jshell/tool/Selector$FormatWhen;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "errorLines", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolution", "Ljdk/internal/jshell/tool/Selector$FormatResolve;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unresolved", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unrcnt", "Ljdk/internal/jshell/tool/Selector$FormatUnresolved;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "errcnt", "Ljdk/internal/jshell/tool/Selector$FormatErrors;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolve", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/jshell/tool/JShellTool;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/JShellTool;Ljdk/jshell/Snippet;Ljdk/jshell/Snippet$Status;ZLjdk/internal/jshell/tool/Selector$FormatAction;Ljdk/internal/jshell/tool/Selector$FormatWhen;Ljava/lang/String;Ljava/util/List;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/JShellTool;Ljdk/jshell/Snippet;Ljdk/jshell/Snippet$Status;ZLjava/util/List;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/JShellTool;Ljdk/jshell/SnippetEvent;Ljdk/internal/jshell/tool/Selector$FormatWhen;Ljava/lang/String;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "displayDeclarationAndValue", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unresolved", "(Ljdk/jshell/DeclarationSnippet;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "custom", "(Ljdk/internal/jshell/tool/Selector$FormatCase;Ljava/lang/String;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "custom", "(Ljdk/internal/jshell/tool/Selector$FormatCase;Ljava/lang/String;)V"));
		}

		[JniSignatureAttribute("Ljdk/jshell/Snippet;", "private final")]
		public Dova.JDK.jdk.jshell.Snippet sn_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.Snippet>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatAction;", "private final")]
		public Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction action_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatWhen;", "private final")]
		public Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatWhen update_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatWhen>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String value_Property
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

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List errorLines_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatResolve;", "private final")]
		public Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatResolve resolution_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatResolve>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String unresolved_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatUnresolved;", "private final")]
		public Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatUnresolved unrcnt_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatUnresolved>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector$FormatErrors;", "private final")]
		public Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatErrors errcnt_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatErrors>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool resolve_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool;", "final")]
		public Dova.JDK.jdk.@internal.jshell.tool.JShellTool this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DisplayEvent(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool;Ljdk/jshell/Snippet;Ljdk/jshell/Snippet$Status;ZLjdk/internal/jshell/tool/Selector$FormatAction;Ljdk/internal/jshell/tool/Selector$FormatWhen;Ljava/lang/String;Ljava/util/List;)V", "private")]
		public DisplayEvent(Dova.JDK.jdk.@internal.jshell.tool.JShellTool arg0, Dova.JDK.jdk.jshell.Snippet arg1, Dova.JDK.jdk.jshell.Snippet.Status arg2, bool arg3, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction arg4, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatWhen arg5, Dova.JDK.java.lang.String arg6, Dova.JDK.java.util.List arg7) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool;Ljdk/jshell/Snippet;Ljdk/jshell/Snippet$Status;ZLjava/util/List;)V", "")]
		public DisplayEvent(Dova.JDK.jdk.@internal.jshell.tool.JShellTool arg0, Dova.JDK.jdk.jshell.Snippet arg1, Dova.JDK.jdk.jshell.Snippet.Status arg2, bool arg3, Dova.JDK.java.util.List arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool;Ljdk/jshell/SnippetEvent;Ljdk/internal/jshell/tool/Selector$FormatWhen;Ljava/lang/String;Ljava/util/List;)V", "")]
		public DisplayEvent(Dova.JDK.jdk.@internal.jshell.tool.JShellTool arg0, Dova.JDK.jdk.jshell.SnippetEvent arg1, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatWhen arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.util.List arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/JShellTool$DisplayEvent;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "private")]
		public void displayDeclarationAndValue()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Ljdk/jshell/DeclarationSnippet;)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String unresolved(Dova.JDK.jdk.jshell.DeclarationSnippet arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/Selector$FormatCase;Ljava/lang/String;Ljava/lang/String;)V", "private")]
		public void custom(Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/Selector$FormatCase;Ljava/lang/String;)V", "private")]
		public void custom(Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$ArgSuggestion;", "static")]
	public partial class ArgSuggestion
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.jshell.SourceCodeAnalysis.Suggestion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ArgSuggestion()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/JShellTool$ArgSuggestion;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "continuation", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "continuation", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matchesType", "()Z"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String continuation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ArgSuggestion(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public ArgSuggestion(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/JShellTool$ArgSuggestion;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String continuation()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool matchesType()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$SnippetPredicate;", "private abstract static interface")]
	public partial interface SnippetPredicate
		: IJavaObject
		, Dova.JDK.java.util.function.Predicate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }


		static SnippetPredicate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/JShellTool$SnippetPredicate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$OptionKind;", "private static final")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/JShellTool$OptionKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_PATH", "Ljdk/internal/jshell/tool/JShellTool$OptionKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODULE_PATH", "Ljdk/internal/jshell/tool/JShellTool$OptionKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ADD_MODULES", "Ljdk/internal/jshell/tool/JShellTool$OptionKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ADD_EXPORTS", "Ljdk/internal/jshell/tool/JShellTool$OptionKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENABLE_PREVIEW", "Ljdk/internal/jshell/tool/JShellTool$OptionKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SOURCE_RELEASE", "Ljdk/internal/jshell/tool/JShellTool$OptionKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENABLE_NATIVE_ACCESS", "Ljdk/internal/jshell/tool/JShellTool$OptionKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TO_COMPILER", "Ljdk/internal/jshell/tool/JShellTool$OptionKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TO_REMOTE_VM", "Ljdk/internal/jshell/tool/JShellTool$OptionKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "optionFlag", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "onlyOne", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "passFlag", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toCompiler", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toRemoteVm", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "showOption", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/jshell/tool/JShellTool$OptionKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;ZZZZZ)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/jshell/tool/JShellTool$OptionKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/jshell/tool/JShellTool$OptionKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/jshell/tool/JShellTool$OptionKind;"));
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$OptionKind;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind CLASS_PATH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$OptionKind;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind MODULE_PATH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$OptionKind;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind ADD_MODULES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$OptionKind;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind ADD_EXPORTS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$OptionKind;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind ENABLE_PREVIEW_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$OptionKind;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind SOURCE_RELEASE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$OptionKind;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind ENABLE_NATIVE_ACCESS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$OptionKind;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind TO_COMPILER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool$OptionKind;", "public static final")]
		public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind TO_REMOTE_VM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String optionFlag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "final")]
		public bool onlyOne_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[10]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[10], value);
			}
		}

		[JniSignatureAttribute("Z", "final")]
		public bool passFlag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[11]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[11], value);
			}
		}

		[JniSignatureAttribute("Z", "final")]
		public bool toCompiler_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[12]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[12], value);
			}
		}

		[JniSignatureAttribute("Z", "final")]
		public bool toRemoteVm_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[13]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[13], value);
			}
		}

		[JniSignatureAttribute("Z", "final")]
		public bool showOption_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[14]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[14], value);
			}
		}

		[JniSignatureAttribute("[Ljdk/internal/jshell/tool/JShellTool$OptionKind;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OptionKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;ZZZZZ)V", "private")]
		public OptionKind(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, bool arg3, bool arg4, bool arg5, bool arg6, bool arg7) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Z)V", "private")]
		public OptionKind(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/JShellTool$OptionKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/jshell/tool/JShellTool$OptionKind;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jshell/tool/JShellTool$OptionKind;", "public static")]
		public static Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/jshell/tool/JShellTool$OptionKind;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.OptionKind>>(ret);
		}
	}
}
