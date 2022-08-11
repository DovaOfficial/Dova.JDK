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

namespace Dova.JDK.jdk.@internal.org.jline.reader.impl;

[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl;", "public")]
public partial class LineReaderImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.jdk.@internal.org.jline.reader.LineReader
	, Dova.JDK.java.io.Flushable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LineReaderImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/reader/impl/LineReaderImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NULL_MASK", "C"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TAB_WIDTH", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_WORDCHARS", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_REMOVE_SUFFIX_CHARS", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_COMMENT_BEGIN", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_SEARCH_TERMINATORS", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_BELL_STYLE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_LIST_MAX", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_MENU_LIST_MAX", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_ERRORS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_BLINK_MATCHING_PAREN", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_AMBIGUOUS_BINDING", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_SECONDARY_PROMPT_PATTERN", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_OTHERS_GROUP_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_ORIGINAL_GROUP_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_COMPLETION_STYLE_STARTING", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_COMPLETION_STYLE_DESCRIPTION", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_COMPLETION_STYLE_GROUP", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_COMPLETION_STYLE_SELECTION", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_COMPLETION_STYLE_BACKGROUND", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_COMPLETION_STYLE_LIST_STARTING", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_COMPLETION_STYLE_LIST_DESCRIPTION", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_COMPLETION_STYLE_LIST_GROUP", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_COMPLETION_STYLE_LIST_SELECTION", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_COMPLETION_STYLE_LIST_BACKGROUND", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_INDENTATION", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_FEATURES_MAX_BUFFER_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_SUGGESTIONS_MIN_BUFFER_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MIN_ROWS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BRACKETED_PASTE_ON", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BRACKETED_PASTE_OFF", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BRACKETED_PASTE_BEGIN", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BRACKETED_PASTE_END", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FOCUS_IN_SEQ", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FOCUS_OUT_SEQ", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "terminal", "Ljdk/internal/org/jline/terminal/Terminal;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "appName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyMaps", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "variables", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "history", "Ljdk/internal/org/jline/reader/History;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "completer", "Ljdk/internal/org/jline/reader/Completer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "highlighter", "Ljdk/internal/org/jline/reader/Highlighter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parser", "Ljdk/internal/org/jline/reader/Parser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expander", "Ljdk/internal/org/jline/reader/Expander;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "completionMatcher", "Ljdk/internal/org/jline/reader/CompletionMatcher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "options", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "buf", "Ljdk/internal/org/jline/reader/Buffer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tailTip", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "autosuggestion", "Ljdk/internal/org/jline/reader/LineReader$SuggestionType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "size", "Ljdk/internal/org/jline/terminal/Size;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prompt", "Ljdk/internal/org/jline/utils/AttributedString;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rightPrompt", "Ljdk/internal/org/jline/utils/AttributedString;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maskingCallback", "Ljdk/internal/org/jline/reader/MaskingCallback;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modifiedHistory", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "historyBuffer", "Ljdk/internal/org/jline/reader/Buffer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "searchBuffer", "Ljava/lang/CharSequence;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "searchTerm", "Ljava/lang/StringBuffer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "searchFailing", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "searchBackward", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "searchIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "doAutosuggestion", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bindingReader", "Ljdk/internal/org/jline/keymap/BindingReader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "findChar", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "findDir", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "findTailAdd", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "searchDir", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "searchString", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "regionMark", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "regionActive", "Ljdk/internal/org/jline/reader/LineReader$RegionType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "forceChar", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "forceLine", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "yankBuffer", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "viMoveMode", "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$ViMoveMode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "killRing", "Ljdk/internal/org/jline/reader/impl/KillRing;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "undo", "Ljdk/internal/org/jline/reader/impl/UndoTree;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isUndo", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lock", "Ljava/util/concurrent/locks/ReentrantLock;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "state", "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "startedReading", "Ljava/util/concurrent/atomic/AtomicBoolean;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reading", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "post", "Ljava/util/function/Supplier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "builtinWidgets", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "widgets", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "count", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mult", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "universal", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "repeatCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isArgDigit", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parsedLine", "Ljdk/internal/org/jline/reader/ParsedLine;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "skipRedisplay", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "display", "Ljdk/internal/org/jline/utils/Display;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "overTyping", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyMap", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "smallTerminalOffset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextCommandFromHistory", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextHistoryId", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "commandsBuffer", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "candidateStartPosition", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESC_PREFIX", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESC_SUFFIX", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MARGIN_BETWEEN_DISPLAY_AND_DESC", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MARGIN_BETWEEN_COLUMNS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MENU_LIST_WIDTH", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/org/jline/terminal/Terminal;Ljava/lang/String;Ljava/util/Map;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/org/jline/terminal/Terminal;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/org/jline/terminal/Terminal;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "println", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "println", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isWhitespace", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBoolean", "(Ljava/lang/String;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInt", "(Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLong", "(Ljava/lang/String;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Ljdk/internal/org/jline/reader/ParsedLine;)Ljdk/internal/org/jline/reader/CompletingParsedLine;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flush", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Ljava/util/regex/Pattern;Ljava/lang/String;I)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "concat", "(Ljava/util/List;Ljdk/internal/org/jline/utils/AttributedStringBuilder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "key", "(Ljdk/internal/org/jline/utils/InfoCmp$Capability;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSet", "(Ljdk/internal/org/jline/reader/LineReader$Option;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readLine", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readLine", "(Ljava/lang/Character;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readLine", "(Ljava/lang/String;Ljava/lang/Character;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readLine", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readLine", "(Ljava/lang/String;Ljava/lang/String;Ljdk/internal/org/jline/reader/MaskingCallback;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readLine", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Character;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readLine", "(Ljava/lang/String;Ljava/lang/Character;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rebind", "(Ljdk/internal/org/jline/keymap/KeyMap;Ljava/lang/String;Ljava/lang/String;C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "option", "(Ljdk/internal/org/jline/reader/LineReader$Option;Z)Ljdk/internal/org/jline/reader/LineReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cleanup", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljdk/internal/org/jline/keymap/KeyMap;Ljava/lang/String;Ljava/lang/Iterable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljdk/internal/org/jline/keymap/KeyMap;Ljava/lang/String;[Ljava/lang/CharSequence;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljdk/internal/org/jline/keymap/KeyMap;Ljdk/internal/org/jline/reader/Widget;[Ljava/lang/CharSequence;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "finish", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeys", "()Ljdk/internal/org/jline/keymap/KeyMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDelimiter", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompleter", "()Ljdk/internal/org/jline/reader/Completer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAlpha", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isWord", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBuffer", "()Ljdk/internal/org/jline/reader/Buffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertTab", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setParser", "(Ljdk/internal/org/jline/reader/Parser;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVariable", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "variable", "(Ljava/lang/String;Ljava/lang/Object;)Ljdk/internal/org/jline/reader/LineReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHighlighter", "()Ljdk/internal/org/jline/reader/Highlighter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setHighlighter", "(Ljdk/internal/org/jline/reader/Highlighter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doReadBinding", "(Ljdk/internal/org/jline/keymap/KeyMap;Ljdk/internal/org/jline/keymap/KeyMap;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expandPromptPattern", "(Ljava/lang/String;ILjava/lang/String;I)Ljdk/internal/org/jline/utils/AttributedString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "callNeg", "(Ljdk/internal/org/jline/reader/Widget;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findeol", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInViMoveOperation", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findbol", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInViChangeOperation", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isViAlphaNum", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forwardWord", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "backwardWord", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doInsertComment", "(Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "beginningOfLine", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putString", "(Ljava/lang/CharSequence;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptLine", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "vigetkey", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "vifindchar", "(Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getViSearchString", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viRepeatSearch", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "builtinWidgets", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doDisplay", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTerminalDumb", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPrompt", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRightPrompt", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "candidateStartPosition", "(Ljava/util/List;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "searchBackwards", "(Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "searchBackwards", "(Ljava/lang/String;IZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "searchBackwards", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "searchForwards", "(Ljava/lang/String;IZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "searchForwards", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "searchForwards", "(Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearScreen", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertClose", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeIndentation", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doViMatchBracket", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBracketType", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "digitArgument", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viDeleteChangeYankToRemap", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "killWholeLine", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viDeleteTo", "(II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pushBackBinding", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pushBackBinding", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viYankTo", "(II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viYankTo", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viChange", "(II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viChange", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doCleanup", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doSearchHistory", "(Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doGetSearchPattern", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFirstWord", "()Ljava/lang/CharSequence;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indention", "(ILjava/lang/StringBuilder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "beginningOfHistory", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endOfHistory", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moveHistory", "(Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moveHistory", "(ZI)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "upLine", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "upHistory", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viFirstNonBlank", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "downLine", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "downHistory", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "historySearchBackward", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "historySearchForward", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viChangeEol", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doViDeleteOrChange", "(IIZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addBuiltinWidget", "(Ljava/util/Map;Ljava/lang/String;Ljdk/internal/org/jline/reader/Widget;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "namedWidget", "(Ljava/lang/String;Ljdk/internal/org/jline/reader/Widget;)Ljdk/internal/org/jline/reader/Widget;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redrawLine", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInViCmdMode", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readBinding", "(Ljdk/internal/org/jline/keymap/KeyMap;Ljdk/internal/org/jline/keymap/KeyMap;)Ljdk/internal/org/jline/reader/Binding;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readBinding", "(Ljdk/internal/org/jline/keymap/KeyMap;)Ljdk/internal/org/jline/reader/Binding;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWidget", "(Ljava/lang/Object;)Ljdk/internal/org/jline/reader/Widget;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "finishBuffer", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readCharacter", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "peekCharacter", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHighlightedBuffer", "(Ljava/lang/String;)Ljdk/internal/org/jline/utils/AttributedString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDisplayedBufferWithPrompts", "(Ljava/util/List;)Ljdk/internal/org/jline/utils/AttributedString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addRightPrompt", "(Ljdk/internal/org/jline/utils/AttributedString;Ljdk/internal/org/jline/utils/AttributedString;)Ljdk/internal/org/jline/utils/AttributedString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertSecondaryPrompts", "(Ljdk/internal/org/jline/utils/AttributedString;Ljava/util/List;)Ljdk/internal/org/jline/utils/AttributedString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertSecondaryPrompts", "(Ljdk/internal/org/jline/utils/AttributedString;Ljava/util/List;Z)Ljdk/internal/org/jline/utils/AttributedString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "displayRows", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "displayRows", "(Ljdk/internal/org/jline/utils/Status;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matchPreviousCommand", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearChoices", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listChoices", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listChoices", "(Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selfInsert", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doComplete", "(Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;ZZZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doComplete", "(Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;ZZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deleteChar", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOriginalGroupName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doList", "(Ljava/util/List;Ljava/lang/String;ZLjava/util/function/BiFunction;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doList", "(Ljava/util/List;Ljava/lang/String;ZLjava/util/function/BiFunction;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doMenu", "(Ljava/util/List;Ljava/lang/String;Ljava/util/function/BiFunction;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextBindingIsComplete", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCandidateComparator", "(ZLjava/lang/String;)Ljava/util/Comparator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeCandidates", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computePost", "(Ljava/util/List;Ljdk/internal/org/jline/reader/Candidate;Ljava/util/List;Ljava/lang/String;)Ljdk/internal/org/jline/reader/impl/LineReaderImpl$PostResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computePost", "(Ljava/util/List;Ljdk/internal/org/jline/reader/Candidate;Ljava/util/List;Ljava/lang/String;Ljava/util/function/Function;IZZZ)Ljdk/internal/org/jline/reader/impl/LineReaderImpl$PostResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGroupComparator", "()Ljava/util/Comparator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOthersGroupName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toColumns", "(Ljava/lang/Object;IILjdk/internal/org/jline/utils/AttributedStringBuilder;Ljdk/internal/org/jline/reader/Candidate;Ljava/lang/String;ZZ[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toColumns", "(Ljava/util/List;Ljdk/internal/org/jline/reader/Candidate;Ljava/lang/String;Ljava/util/function/Function;IZ)Ljdk/internal/org/jline/reader/impl/LineReaderImpl$PostResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "promptLines", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompletionStyleGroup", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompletionStyleGroup", "(Z)Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompletionStyleBackground", "(Z)Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompletionStyleBackground", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompletionStyleSelection", "(Z)Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompletionStyleSelection", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompletionStyleStarting", "(Z)Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompletionStyleStarting", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompletionStyleDescription", "(Z)Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompletionStyleDescription", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompletionStyleListStarting", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompletionStyleListDescription", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompletionStyleListGroup", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompletionStyleListSelection", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompletionStyleListBackground", "()Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompletionStyle", "(Ljava/lang/String;Ljava/lang/String;)Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doCopyKillRegion", "(Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "yankPop", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doReadStringUntil", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viCmd", "()Ljdk/internal/org/jline/keymap/KeyMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viInsertion", "()Ljdk/internal/org/jline/keymap/KeyMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viOpp", "()Ljdk/internal/org/jline/keymap/KeyMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bindConsoleChars", "(Ljdk/internal/org/jline/keymap/KeyMap;Ljdk/internal/org/jline/terminal/Attributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bindKeys", "(Ljdk/internal/org/jline/keymap/KeyMap;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bindArrowKeys", "(Ljdk/internal/org/jline/keymap/KeyMap;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCompleter", "(Ljdk/internal/org/jline/reader/Completer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setHistory", "(Ljdk/internal/org/jline/reader/History;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setExpander", "(Ljdk/internal/org/jline/reader/Expander;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCompletionMatcher", "(Ljdk/internal/org/jline/reader/CompletionMatcher;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "freshLine", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isKeyMap", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleSignal", "(Ljdk/internal/org/jline/terminal/Terminal$Signal;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viForwardChar", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viBackwardChar", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viForwardWord", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viForwardBlankWord", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emacsForwardWord", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viForwardBlankWordEnd", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viForwardWordEnd", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viBackwardWord", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viBackwardBlankWord", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viBackwardWordEnd", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viBackwardBlankWordEnd", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emacsBackwardWord", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "backwardDeleteWord", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viBackwardKillWord", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "backwardKillWord", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyPrevWord", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "upCaseWord", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "downCaseWord", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "capitalizeWord", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deleteWord", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "killWord", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transposeWords", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertComment", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viInsertComment", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viFindNextChar", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viFindPrevChar", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viFindNextCharSkip", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viFindPrevCharSkip", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viRepeatFind", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viRevRepeatFind", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viHistorySearchForward", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viHistorySearchBackward", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viRevRepeatSearch", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertCloseCurly", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertCloseParen", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertCloseSquare", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viMatchBracket", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "undefinedKey", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transposeChars", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendBreak", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "backwardChar", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forwardChar", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viDigitOrBeginningOfLine", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "universalArgument", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "argumentBase", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "negArgument", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viDelete", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viYankWholeLine", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "historyIncrementalSearchForward", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "historyIncrementalSearchBackward", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "quit", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptAndHold", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptLineAndDownHistory", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptAndInferNextHistory", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selfInsertUnmeta", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "overwriteMode", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "beginningOfBufferOrHistory", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endOfBufferOrHistory", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "beginningOfLineHist", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endOfLineHist", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viUpLineOrHistory", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viDownLineOrHistory", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "upLineOrHistory", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "upLineOrSearch", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "downLineOrHistory", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "downLineOrSearch", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viCmdMode", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viInsert", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viAddNext", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viAddEol", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emacsEditingMode", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viChangeWholeLine", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viKillEol", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "quotedInsert", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viJoin", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viKillWholeLine", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viInsertBol", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "backwardDeleteChar", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viBeginningOfLine", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viEndOfLine", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viBackwardDeleteChar", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viDeleteChar", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viSwapCase", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viReplaceChars", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viOpenLineAbove", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viOpenLineBelow", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viPutAfter", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viPutBefore", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doLowercaseVersion", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMarkCommand", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exchangePointAndMark", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visualMode", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visualLineMode", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deactivateRegion", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "whatCursorPosition", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "editAndExecute", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expandWord", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expandOrComplete", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expandOrCompletePrefix", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "completeWord", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "menuComplete", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "menuExpandOrComplete", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "completePrefix", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deleteCharOrList", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildStyle", "(Ljava/lang/String;)Ljdk/internal/org/jline/utils/AttributedStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "killBuffer", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "killLine", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "backwardKillLine", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "killRegion", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyRegionAsKill", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "beginPaste", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusIn", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusOut", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTerminal", "()Ljdk/internal/org/jline/terminal/Terminal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParser", "()Ljdk/internal/org/jline/reader/Parser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "beep", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "yank", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouse", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emacs", "()Ljdk/internal/org/jline/keymap/KeyMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redisplay", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redisplay", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redo", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "undo", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBuiltinWidgets", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAppName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runMacro", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHistory", "()Ljdk/internal/org/jline/reader/History;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpander", "()Ljdk/internal/org/jline/reader/Expander;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeyMaps", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeyMap", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setKeyMap", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParsedLine", "()Ljdk/internal/org/jline/reader/ParsedLine;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRegionActive", "()Ljdk/internal/org/jline/reader/LineReader$RegionType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRegionMark", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addCommandsInBuffer", "(Ljava/util/Collection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "editAndAddInBuffer", "(Ljava/io/File;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastBinding", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTailTip", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTailTip", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAutosuggestion", "(Ljdk/internal/org/jline/reader/LineReader$SuggestionType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAutosuggestion", "()Ljdk/internal/org/jline/reader/LineReader$SuggestionType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultKeyMaps", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printAbove", "(Ljdk/internal/org/jline/utils/AttributedString;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printAbove", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isReading", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "callWidget", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVariables", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setVariable", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOpt", "(Ljdk/internal/org/jline/reader/LineReader$Option;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unsetOpt", "(Ljdk/internal/org/jline/reader/LineReader$Option;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWidgets", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expandHistory", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "menu", "()Ljdk/internal/org/jline/keymap/KeyMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "safe", "()Ljdk/internal/org/jline/keymap/KeyMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visual", "()Ljdk/internal/org/jline/keymap/KeyMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endOfLine", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "switchCase", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSearchTerm", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readMouseEvent", "()Ljdk/internal/org/jline/terminal/MouseEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBuffer", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBuffer", "(Ljdk/internal/org/jline/reader/Buffer;)V"));
	}

	[JniSignatureAttribute("C", "public static final")]
	public static char NULL_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int TAB_WIDTH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DEFAULT_WORDCHARS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DEFAULT_REMOVE_SUFFIX_CHARS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DEFAULT_COMMENT_BEGIN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DEFAULT_SEARCH_TERMINATORS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DEFAULT_BELL_STYLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int DEFAULT_LIST_MAX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int DEFAULT_MENU_LIST_MAX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int DEFAULT_ERRORS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("J", "public static final")]
	public static long DEFAULT_BLINK_MATCHING_PAREN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("J", "public static final")]
	public static long DEFAULT_AMBIGUOUS_BINDING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DEFAULT_SECONDARY_PROMPT_PATTERN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DEFAULT_OTHERS_GROUP_NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DEFAULT_ORIGINAL_GROUP_NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DEFAULT_COMPLETION_STYLE_STARTING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DEFAULT_COMPLETION_STYLE_DESCRIPTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DEFAULT_COMPLETION_STYLE_GROUP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DEFAULT_COMPLETION_STYLE_SELECTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DEFAULT_COMPLETION_STYLE_BACKGROUND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DEFAULT_COMPLETION_STYLE_LIST_STARTING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DEFAULT_COMPLETION_STYLE_LIST_DESCRIPTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DEFAULT_COMPLETION_STYLE_LIST_GROUP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DEFAULT_COMPLETION_STYLE_LIST_SELECTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DEFAULT_COMPLETION_STYLE_LIST_BACKGROUND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int DEFAULT_INDENTATION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int DEFAULT_FEATURES_MAX_BUFFER_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int DEFAULT_SUGGESTIONS_MIN_BUFFER_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[27]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[27], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MIN_ROWS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String BRACKETED_PASTE_ON_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String BRACKETED_PASTE_OFF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String BRACKETED_PASTE_BEGIN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String BRACKETED_PASTE_END_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String FOCUS_IN_SEQ_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String FOCUS_OUT_SEQ_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Terminal;", "protected final")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.Terminal terminal_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Terminal>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected final")]
	public Dova.JDK.java.lang.String appName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "protected final")]
	public Dova.JDK.java.util.Map keyMaps_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "protected final")]
	public Dova.JDK.java.util.Map variables_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/History;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.reader.History history_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.History>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/Completer;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.reader.Completer completer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.Completer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/Highlighter;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.reader.Highlighter highlighter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.Highlighter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/Parser;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.reader.Parser parser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.Parser>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/Expander;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.reader.Expander expander_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.Expander>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/CompletionMatcher;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.reader.CompletionMatcher completionMatcher_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[44]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.CompletionMatcher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "protected final")]
	public Dova.JDK.java.util.Map options_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[45]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/Buffer;", "protected final")]
	public Dova.JDK.jdk.@internal.org.jline.reader.Buffer buf_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[46]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.Buffer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String tailTip_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[47]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/LineReader$SuggestionType;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.reader.LineReader.SuggestionType autosuggestion_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[48]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.LineReader.SuggestionType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Size;", "protected final")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.Size size_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[49]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Size>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[49], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/utils/AttributedString;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedString prompt_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[50]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[50], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/utils/AttributedString;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedString rightPrompt_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[51]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[51], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/MaskingCallback;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.reader.MaskingCallback maskingCallback_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[52]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.MaskingCallback>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[52], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "protected")]
	public Dova.JDK.java.util.Map modifiedHistory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[53]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[53], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/Buffer;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.reader.Buffer historyBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[54]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.Buffer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[54], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/CharSequence;", "protected")]
	public Dova.JDK.java.lang.CharSequence searchBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[55]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.CharSequence>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[55], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/StringBuffer;", "protected")]
	public Dova.JDK.java.lang.StringBuffer searchTerm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[56]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuffer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[56], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool searchFailing_Property
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

	[JniSignatureAttribute("Z", "protected")]
	public bool searchBackward_Property
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

	[JniSignatureAttribute("I", "protected")]
	public int searchIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[59]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[59], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool doAutosuggestion_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[60]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[60], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/keymap/BindingReader;", "protected final")]
	public Dova.JDK.jdk.@internal.org.jline.keymap.BindingReader bindingReader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[61]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.keymap.BindingReader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[61], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int findChar_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[62]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[62], value);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int findDir_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[63]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[63], value);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int findTailAdd_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[64]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[64], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int searchDir_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[65]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[65], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String searchString_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[66]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[66], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int regionMark_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[67]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[67], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/LineReader$RegionType;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.reader.LineReader.RegionType regionActive_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[68]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.LineReader.RegionType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[68], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool forceChar_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[69]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[69], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool forceLine_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[70]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[70], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String yankBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[71]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[71], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$ViMoveMode;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.ViMoveMode viMoveMode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[72]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.ViMoveMode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[72], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/KillRing;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.reader.impl.KillRing killRing_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[73]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.KillRing>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[73], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/UndoTree;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.reader.impl.UndoTree undo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[74]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.UndoTree>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[74], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool isUndo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[75]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[75], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/ReentrantLock;", "protected final")]
	public Dova.JDK.java.util.concurrent.locks.ReentrantLock @lock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[76]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.ReentrantLock>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[76], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.State state_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[77]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.State>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[77], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicBoolean;", "protected final")]
	public Dova.JDK.java.util.concurrent.atomic.AtomicBoolean startedReading_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[78]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicBoolean>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[78], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool reading_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[79]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[79], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/function/Supplier;", "protected")]
	public Dova.JDK.java.util.function.Supplier post_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[80]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Supplier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[80], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "protected")]
	public Dova.JDK.java.util.Map builtinWidgets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[81]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[81], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "protected")]
	public Dova.JDK.java.util.Map widgets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[82]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[82], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int count_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[83]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[83], value);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int mult_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[84]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[84], value);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int universal_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[85]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[85], value);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int repeatCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[86]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[86], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool isArgDigit_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[87]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[87], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/ParsedLine;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.reader.ParsedLine parsedLine_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[88]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.ParsedLine>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[88], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool skipRedisplay_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[89]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[89], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/utils/Display;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.utils.Display display_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[90]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.Display>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[90], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool overTyping_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[91]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[91], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String keyMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[92]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[92], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int smallTerminalOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[93]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[93], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool nextCommandFromHistory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[94]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[94], value);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int nextHistoryId_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[95]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[95], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "protected")]
	public Dova.JDK.java.util.List commandsBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[96]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[96], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int candidateStartPosition_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[97]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[97], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String DESC_PREFIX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[98]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[98], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String DESC_SUFFIX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[99]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[99], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MARGIN_BETWEEN_DISPLAY_AND_DESC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[100]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[100], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MARGIN_BETWEEN_COLUMNS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[101]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[101], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MENU_LIST_WIDTH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[102]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[102], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LineReaderImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Terminal;Ljava/lang/String;Ljava/util/Map;)V", "public")]
	public LineReaderImpl(Dova.JDK.jdk.@internal.org.jline.terminal.Terminal arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Map arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Terminal;Ljava/lang/String;)V", "public")]
	public LineReaderImpl(Dova.JDK.jdk.@internal.org.jline.terminal.Terminal arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Terminal;)V", "public")]
	public LineReaderImpl(Dova.JDK.jdk.@internal.org.jline.terminal.Terminal arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/reader/impl/LineReaderImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
	public void println(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()V", "")]
	public void println()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(I)Z", "protected")]
	public bool isWhitespace(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)Z", "")]
	public bool getBoolean(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)I", "")]
	public int getInt(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;J)J", "")]
	public long getLong(Dova.JDK.java.lang.String arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool clear()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/ParsedLine;)Ljdk/internal/org/jline/reader/CompletingParsedLine;", "private")]
	public Dova.JDK.jdk.@internal.org.jline.reader.CompletingParsedLine wrap(Dova.JDK.jdk.@internal.org.jline.reader.ParsedLine arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.CompletingParsedLine>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void flush()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("(Ljava/util/regex/Pattern;Ljava/lang/String;I)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List matches(Dova.JDK.java.util.regex.Pattern arg0, Dova.JDK.java.lang.String arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljdk/internal/org/jline/utils/AttributedStringBuilder;)V", "private")]
	public void concat(Dova.JDK.java.util.List arg0, Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/utils/InfoCmp$Capability;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String key(Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/LineReader$Option;)Z", "public")]
	public bool isSet(Dova.JDK.jdk.@internal.org.jline.reader.LineReader.Option arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
	public void print(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String readLine(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Character;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String readLine(Dova.JDK.java.lang.Character arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Character;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String readLine(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Character arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String readLine()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljdk/internal/org/jline/reader/MaskingCallback;Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String readLine(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.@internal.org.jline.reader.MaskingCallback arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Character;Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String readLine(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Character arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Character;Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String readLine(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Character arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/keymap/KeyMap;Ljava/lang/String;Ljava/lang/String;C)V", "private")]
	public void rebind(Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, char arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/LineReader$Option;Z)Ljdk/internal/org/jline/reader/LineReader;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.LineReader option(Dova.JDK.jdk.@internal.org.jline.reader.LineReader.Option arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.LineReader>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void cleanup()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23]);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/keymap/KeyMap;Ljava/lang/String;Ljava/lang/Iterable;)V", "private")]
	public void bind(Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Iterable arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/keymap/KeyMap;Ljava/lang/String;[Ljava/lang/CharSequence;)V", "private transient")]
	public void bind(Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.CharSequence> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/keymap/KeyMap;Ljdk/internal/org/jline/reader/Widget;[Ljava/lang/CharSequence;)V", "private transient")]
	public void bind(Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap arg0, Dova.JDK.jdk.@internal.org.jline.reader.Widget arg1, JavaArray<Dova.JDK.java.lang.CharSequence> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String finish(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getString(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/keymap/KeyMap;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap getKeys()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap>(ret);
	}

	[JniSignatureAttribute("(I)Z", "protected")]
	public bool isDelimiter(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/reader/Completer;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.Completer getCompleter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.Completer>(ret);
	}

	[JniSignatureAttribute("(I)Z", "protected")]
	public bool isAlpha(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "protected")]
	public bool isWord(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/reader/Buffer;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.Buffer getBuffer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.Buffer>(ret);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool insertTab()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[35]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/Parser;)V", "public")]
	public void setParser(Dova.JDK.jdk.@internal.org.jline.reader.Parser arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getVariable(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)Ljdk/internal/org/jline/reader/LineReader;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.LineReader variable(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.LineReader>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/reader/Highlighter;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.Highlighter getHighlighter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.Highlighter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/Highlighter;)V", "public")]
	public void setHighlighter(Dova.JDK.jdk.@internal.org.jline.reader.Highlighter arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/keymap/KeyMap;Ljdk/internal/org/jline/keymap/KeyMap;)Ljava/lang/Object;", "protected")]
	public Dova.JDK.java.lang.Object doReadBinding(Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap arg0, Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;I)Ljdk/internal/org/jline/utils/AttributedString;", "private")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedString expandPromptPattern(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/Widget;)Z", "private")]
	public bool callNeg(Dova.JDK.jdk.@internal.org.jline.reader.Widget arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "private")]
	public int findeol()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[44]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool isInViMoveOperation()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[45]);
		return ret;
	}

	[JniSignatureAttribute("()I", "private")]
	public int findbol()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[46]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool isInViChangeOperation()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[47]);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "protected")]
	public bool isViAlphaNum(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool forwardWord()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[49]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool backwardWord()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[50]);
		return ret;
	}

	[JniSignatureAttribute("(Z)Z", "protected")]
	public bool doInsertComment(bool arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool beginningOfLine()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[52]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)V", "public")]
	public void putString(Dova.JDK.java.lang.CharSequence arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool acceptLine()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[54]);
		return ret;
	}

	[JniSignatureAttribute("()I", "private")]
	public int vigetkey()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[55]);
		return ret;
	}

	[JniSignatureAttribute("(Z)Z", "private")]
	public bool vifindchar(bool arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool getViSearchString()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[57]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viRepeatSearch()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[58]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "protected")]
	public Dova.JDK.java.util.Map builtinWidgets()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void doDisplay()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60]);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool isTerminalDumb()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[61]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setPrompt(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setRightPrompt(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/List;)I", "private")]
	public int candidateStartPosition(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)I", "public")]
	public int searchBackwards(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[65], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;IZ)I", "public")]
	public int searchBackwards(Dova.JDK.java.lang.String arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int searchBackwards(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[67], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;IZ)I", "public")]
	public int searchForwards(Dova.JDK.java.lang.String arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[68], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int searchForwards(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[69], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)I", "public")]
	public int searchForwards(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool clearScreen()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[71]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "protected")]
	public bool insertClose(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[72], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void removeIndentation()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[73]);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool doViMatchBracket()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[74]);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "protected")]
	public int getBracketType(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[75], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool digitArgument()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[76]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String viDeleteChangeYankToRemap(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool killWholeLine()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[78]);
		return ret;
	}

	[JniSignatureAttribute("(II)Z", "protected")]
	public bool viDeleteTo(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[79], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void pushBackBinding()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[80]);
	}

	[JniSignatureAttribute("(Z)V", "private")]
	public void pushBackBinding(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[81], arg0);
	}

	[JniSignatureAttribute("(II)Z", "protected")]
	public bool viYankTo(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[82], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viYankTo()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[83]);
		return ret;
	}

	[JniSignatureAttribute("(II)Z", "protected")]
	public bool viChange(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[84], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viChange()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[85]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "protected")]
	public void doCleanup(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[86], arg0);
	}

	[JniSignatureAttribute("(Z)Z", "protected")]
	public bool doSearchHistory(bool arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[87], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String doGetSearchPattern()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[88]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/CharSequence;", "private")]
	public Dova.JDK.java.lang.CharSequence getFirstWord()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[89]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.CharSequence>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/StringBuilder;)V", "")]
	public void indention(int arg0, Dova.JDK.java.lang.StringBuilder arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[90], arg0, arg1);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool beginningOfHistory()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[91]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool endOfHistory()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[92]);
		return ret;
	}

	[JniSignatureAttribute("(Z)Z", "protected")]
	public bool moveHistory(bool arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[93], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ZI)Z", "protected")]
	public bool moveHistory(bool arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[94], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool upLine()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[95]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool upHistory()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[96]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viFirstNonBlank()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[97]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool downLine()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[98]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool downHistory()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[99]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool historySearchBackward()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[100]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool historySearchForward()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[101]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viChangeEol()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[102]);
		return ret;
	}

	[JniSignatureAttribute("(IIZ)Z", "protected")]
	public bool doViDeleteOrChange(int arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[103], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljava/lang/String;Ljdk/internal/org/jline/reader/Widget;)V", "private")]
	public void addBuiltinWidget(Dova.JDK.java.util.Map arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.@internal.org.jline.reader.Widget arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[104], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljdk/internal/org/jline/reader/Widget;)Ljdk/internal/org/jline/reader/Widget;", "private")]
	public Dova.JDK.jdk.@internal.org.jline.reader.Widget namedWidget(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.@internal.org.jline.reader.Widget arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[105], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.Widget>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool redrawLine()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[106]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool isInViCmdMode()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[107]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/keymap/KeyMap;Ljdk/internal/org/jline/keymap/KeyMap;)Ljdk/internal/org/jline/reader/Binding;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.Binding readBinding(Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap arg0, Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[108], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.Binding>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/keymap/KeyMap;)Ljdk/internal/org/jline/reader/Binding;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.Binding readBinding(Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[109], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.Binding>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljdk/internal/org/jline/reader/Widget;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.reader.Widget getWidget(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[110], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.Widget>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String finishBuffer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[111]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int readCharacter()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[112]);
		return ret;
	}

	[JniSignatureAttribute("(J)I", "public")]
	public int peekCharacter(long arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[113], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/org/jline/utils/AttributedString;", "private")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedString getHighlightedBuffer(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[114], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljdk/internal/org/jline/utils/AttributedString;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedString getDisplayedBufferWithPrompts(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[115], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/utils/AttributedString;Ljdk/internal/org/jline/utils/AttributedString;)Ljdk/internal/org/jline/utils/AttributedString;", "private")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedString addRightPrompt(Dova.JDK.jdk.@internal.org.jline.utils.AttributedString arg0, Dova.JDK.jdk.@internal.org.jline.utils.AttributedString arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[116], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/utils/AttributedString;Ljava/util/List;)Ljdk/internal/org/jline/utils/AttributedString;", "private")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedString insertSecondaryPrompts(Dova.JDK.jdk.@internal.org.jline.utils.AttributedString arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[117], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/utils/AttributedString;Ljava/util/List;Z)Ljdk/internal/org/jline/utils/AttributedString;", "private")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedString insertSecondaryPrompts(Dova.JDK.jdk.@internal.org.jline.utils.AttributedString arg0, Dova.JDK.java.util.List arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[118], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
	}

	[JniSignatureAttribute("()I", "private")]
	public int displayRows()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[119]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/utils/Status;)I", "private")]
	public int displayRows(Dova.JDK.jdk.@internal.org.jline.utils.Status arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[120], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String matchPreviousCommand(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[121], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool clearChoices()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[122]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool listChoices()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[123]);
		return ret;
	}

	[JniSignatureAttribute("(Z)Z", "private")]
	public bool listChoices(bool arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[124], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool selfInsert()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[125]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;ZZZ)Z", "protected")]
	public bool doComplete(Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.CompletionType arg0, bool arg1, bool arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[126], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;ZZ)Z", "protected")]
	public bool doComplete(Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.CompletionType arg0, bool arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[127], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool deleteChar()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[128]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String getOriginalGroupName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[129]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/lang/String;ZLjava/util/function/BiFunction;)Z", "protected")]
	public bool doList(Dova.JDK.java.util.List arg0, Dova.JDK.java.lang.String arg1, bool arg2, Dova.JDK.java.util.function.BiFunction arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[130], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/lang/String;ZLjava/util/function/BiFunction;Z)Z", "protected")]
	public bool doList(Dova.JDK.java.util.List arg0, Dova.JDK.java.lang.String arg1, bool arg2, Dova.JDK.java.util.function.BiFunction arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[131], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/lang/String;Ljava/util/function/BiFunction;)Z", "protected")]
	public bool doMenu(Dova.JDK.java.util.List arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.function.BiFunction arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[132], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool nextBindingIsComplete()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[133]);
		return ret;
	}

	[JniSignatureAttribute("(ZLjava/lang/String;)Ljava/util/Comparator;", "protected")]
	public Dova.JDK.java.util.Comparator getCandidateComparator(bool arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[134], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "private")]
	public void mergeCandidates(Dova.JDK.java.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[135], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljdk/internal/org/jline/reader/Candidate;Ljava/util/List;Ljava/lang/String;)Ljdk/internal/org/jline/reader/impl/LineReaderImpl$PostResult;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.PostResult computePost(Dova.JDK.java.util.List arg0, Dova.JDK.jdk.@internal.org.jline.reader.Candidate arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[136], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.PostResult>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljdk/internal/org/jline/reader/Candidate;Ljava/util/List;Ljava/lang/String;Ljava/util/function/Function;IZZZ)Ljdk/internal/org/jline/reader/impl/LineReaderImpl$PostResult;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.PostResult computePost(Dova.JDK.java.util.List arg0, Dova.JDK.jdk.@internal.org.jline.reader.Candidate arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.util.function.Function arg4, int arg5, bool arg6, bool arg7, bool arg8)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[137], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.PostResult>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Comparator;", "protected")]
	public Dova.JDK.java.util.Comparator getGroupComparator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[138]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String getOthersGroupName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[139]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;IILjdk/internal/org/jline/utils/AttributedStringBuilder;Ljdk/internal/org/jline/reader/Candidate;Ljava/lang/String;ZZ[I)V", "protected")]
	public void toColumns(Dova.JDK.java.lang.Object arg0, int arg1, int arg2, Dova.JDK.jdk.@internal.org.jline.utils.AttributedStringBuilder arg3, Dova.JDK.jdk.@internal.org.jline.reader.Candidate arg4, Dova.JDK.java.lang.String arg5, bool arg6, bool arg7, JavaArray<int> arg8)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[140], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljdk/internal/org/jline/reader/Candidate;Ljava/lang/String;Ljava/util/function/Function;IZ)Ljdk/internal/org/jline/reader/impl/LineReaderImpl$PostResult;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.PostResult toColumns(Dova.JDK.java.util.List arg0, Dova.JDK.jdk.@internal.org.jline.reader.Candidate arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.function.Function arg3, int arg4, bool arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[141], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.PostResult>(ret);
	}

	[JniSignatureAttribute("()I", "private")]
	public int promptLines()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[142]);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle getCompletionStyleGroup()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[143]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("(Z)Ljdk/internal/org/jline/utils/AttributedStyle;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle getCompletionStyleGroup(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[144], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("(Z)Ljdk/internal/org/jline/utils/AttributedStyle;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle getCompletionStyleBackground(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[145], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle getCompletionStyleBackground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[146]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("(Z)Ljdk/internal/org/jline/utils/AttributedStyle;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle getCompletionStyleSelection(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[147], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle getCompletionStyleSelection()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[148]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("(Z)Ljdk/internal/org/jline/utils/AttributedStyle;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle getCompletionStyleStarting(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[149], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle getCompletionStyleStarting()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[150]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("(Z)Ljdk/internal/org/jline/utils/AttributedStyle;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle getCompletionStyleDescription(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[151], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle getCompletionStyleDescription()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[152]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle getCompletionStyleListStarting()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[153]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle getCompletionStyleListDescription()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[154]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle getCompletionStyleListGroup()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[155]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle getCompletionStyleListSelection()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[156]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedStyle;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle getCompletionStyleListBackground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[157]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljdk/internal/org/jline/utils/AttributedStyle;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle getCompletionStyle(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[158], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("(Z)Z", "private")]
	public bool doCopyKillRegion(bool arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[159], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool yankPop()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[160]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String doReadStringUntil(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[161], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/keymap/KeyMap;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap viCmd()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[162]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/keymap/KeyMap;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap viInsertion()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[163]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/keymap/KeyMap;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap viOpp()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[164]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/keymap/KeyMap;Ljdk/internal/org/jline/terminal/Attributes;)V", "private")]
	public void bindConsoleChars(Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap arg0, Dova.JDK.jdk.@internal.org.jline.terminal.Attributes arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[165], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/keymap/KeyMap;)V", "private")]
	public void bindKeys(Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[166], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/keymap/KeyMap;)V", "private")]
	public void bindArrowKeys(Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[167], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/Completer;)V", "public")]
	public void setCompleter(Dova.JDK.jdk.@internal.org.jline.reader.Completer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[168], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/History;)V", "public")]
	public void setHistory(Dova.JDK.jdk.@internal.org.jline.reader.History arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[169], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/Expander;)V", "public")]
	public void setExpander(Dova.JDK.jdk.@internal.org.jline.reader.Expander arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[170], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/CompletionMatcher;)V", "public")]
	public void setCompletionMatcher(Dova.JDK.jdk.@internal.org.jline.reader.CompletionMatcher arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[171], arg0);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool freshLine()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[172]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool isKeyMap(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[173], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Terminal$Signal;)V", "protected")]
	public void handleSignal(Dova.JDK.jdk.@internal.org.jline.terminal.Terminal.Signal arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[174], arg0);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viForwardChar()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[175]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viBackwardChar()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[176]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viForwardWord()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[177]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viForwardBlankWord()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[178]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool emacsForwardWord()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[179]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viForwardBlankWordEnd()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[180]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viForwardWordEnd()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[181]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viBackwardWord()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[182]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viBackwardBlankWord()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[183]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viBackwardWordEnd()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[184]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viBackwardBlankWordEnd()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[185]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool emacsBackwardWord()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[186]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool backwardDeleteWord()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[187]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viBackwardKillWord()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[188]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool backwardKillWord()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[189]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool copyPrevWord()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[190]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool upCaseWord()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[191]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool downCaseWord()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[192]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool capitalizeWord()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[193]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool deleteWord()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[194]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool killWord()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[195]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool transposeWords()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[196]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool insertComment()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[197]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viInsertComment()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[198]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viFindNextChar()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[199]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viFindPrevChar()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[200]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viFindNextCharSkip()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[201]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viFindPrevCharSkip()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[202]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viRepeatFind()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[203]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viRevRepeatFind()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[204]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viHistorySearchForward()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[205]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viHistorySearchBackward()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[206]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viRevRepeatSearch()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[207]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool insertCloseCurly()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[208]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool insertCloseParen()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[209]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool insertCloseSquare()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[210]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viMatchBracket()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[211]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool undefinedKey()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[212]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool transposeChars()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[213]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool sendBreak()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[214]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool backwardChar()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[215]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool forwardChar()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[216]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viDigitOrBeginningOfLine()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[217]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool universalArgument()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[218]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool argumentBase()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[219]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool negArgument()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[220]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viDelete()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[221]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viYankWholeLine()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[222]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool historyIncrementalSearchForward()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[223]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool historyIncrementalSearchBackward()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[224]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool quit()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[225]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool acceptAndHold()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[226]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool acceptLineAndDownHistory()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[227]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool acceptAndInferNextHistory()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[228]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool selfInsertUnmeta()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[229]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool overwriteMode()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[230]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool beginningOfBufferOrHistory()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[231]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool endOfBufferOrHistory()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[232]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool beginningOfLineHist()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[233]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool endOfLineHist()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[234]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viUpLineOrHistory()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[235]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viDownLineOrHistory()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[236]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool upLineOrHistory()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[237]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool upLineOrSearch()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[238]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool downLineOrHistory()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[239]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool downLineOrSearch()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[240]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viCmdMode()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[241]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viInsert()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[242]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viAddNext()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[243]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viAddEol()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[244]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool emacsEditingMode()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[245]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viChangeWholeLine()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[246]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viKillEol()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[247]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool quotedInsert()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[248]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viJoin()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[249]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viKillWholeLine()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[250]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viInsertBol()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[251]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool backwardDeleteChar()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[252]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viBeginningOfLine()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[253]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viEndOfLine()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[254]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viBackwardDeleteChar()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[255]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viDeleteChar()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[256]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viSwapCase()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[257]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viReplaceChars()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[258]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viOpenLineAbove()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[259]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viOpenLineBelow()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[260]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viPutAfter()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[261]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool viPutBefore()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[262]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool doLowercaseVersion()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[263]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool setMarkCommand()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[264]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool exchangePointAndMark()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[265]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool visualMode()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[266]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool visualLineMode()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[267]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool deactivateRegion()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[268]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool whatCursorPosition()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[269]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool editAndExecute()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[270]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool expandWord()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[271]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool expandOrComplete()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[272]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool expandOrCompletePrefix()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[273]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool completeWord()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[274]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool menuComplete()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[275]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool menuExpandOrComplete()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[276]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool completePrefix()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[277]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool deleteCharOrList()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[278]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/org/jline/utils/AttributedStyle;", "protected")]
	public Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle buildStyle(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[279], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedStyle>(ret);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool killBuffer()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[280]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool killLine()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[281]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool backwardKillLine()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[282]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool killRegion()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[283]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool copyRegionAsKill()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[284]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool beginPaste()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[285]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool focusIn()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[286]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool focusOut()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[287]);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/terminal/Terminal;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.Terminal getTerminal()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[288]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Terminal>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/reader/Parser;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.Parser getParser()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[289]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.Parser>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool beep()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[290]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool yank()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[291]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool mouse()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[292]);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/keymap/KeyMap;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap emacs()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[293]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap>(ret);
	}

	[JniSignatureAttribute("(Z)V", "protected")]
	public void redisplay(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[294], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool redisplay()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[295]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool redo()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[296]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool undo()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[297]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public")]
	public Dova.JDK.java.util.Map getBuiltinWidgets()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[298]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getAppName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[299]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void runMacro(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[300], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/reader/History;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.History getHistory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[301]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.History>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/reader/Expander;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.Expander getExpander()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[302]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.Expander>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public")]
	public Dova.JDK.java.util.Map getKeyMaps()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[303]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getKeyMap()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[304]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool setKeyMap(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[305], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/reader/ParsedLine;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.ParsedLine getParsedLine()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[306]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.ParsedLine>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/reader/LineReader$RegionType;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.LineReader.RegionType getRegionActive()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[307]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.LineReader.RegionType>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getRegionMark()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[308]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)V", "public")]
	public void addCommandsInBuffer(Dova.JDK.java.util.Collection arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[309], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/File;)V", "public")]
	public void editAndAddInBuffer(Dova.JDK.java.io.File arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[310], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getLastBinding()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[311]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getTailTip()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[312]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setTailTip(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[313], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/LineReader$SuggestionType;)V", "public")]
	public void setAutosuggestion(Dova.JDK.jdk.@internal.org.jline.reader.LineReader.SuggestionType arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[314], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/reader/LineReader$SuggestionType;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.LineReader.SuggestionType getAutosuggestion()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[315]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.LineReader.SuggestionType>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public")]
	public Dova.JDK.java.util.Map defaultKeyMaps()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[316]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/utils/AttributedString;)V", "public")]
	public void printAbove(Dova.JDK.jdk.@internal.org.jline.utils.AttributedString arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[317], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void printAbove(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[318], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isReading()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[319]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void callWidget(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[320], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public")]
	public Dova.JDK.java.util.Map getVariables()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[321]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void setVariable(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[322], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/LineReader$Option;)V", "public")]
	public void setOpt(Dova.JDK.jdk.@internal.org.jline.reader.LineReader.Option arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[323], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/LineReader$Option;)V", "public")]
	public void unsetOpt(Dova.JDK.jdk.@internal.org.jline.reader.LineReader.Option arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[324], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public")]
	public Dova.JDK.java.util.Map getWidgets()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[325]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool expandHistory()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[326]);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/keymap/KeyMap;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap menu()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[327]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/keymap/KeyMap;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap safe()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[328]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/keymap/KeyMap;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap visual()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[329]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.keymap.KeyMap>(ret);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool endOfLine()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[330]);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "protected")]
	public int switchCase(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[331], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getSearchTerm()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[332]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/terminal/MouseEvent;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.MouseEvent readMouseEvent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[333]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.MouseEvent>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
	public void setBuffer(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[334], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/Buffer;)V", "protected")]
	public void setBuffer(Dova.JDK.jdk.@internal.org.jline.reader.Buffer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[335], arg0);
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$ViMoveMode;", "protected static final")]
	public partial class ViMoveMode
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ViMoveMode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$ViMoveMode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NORMAL", "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$ViMoveMode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "YANK", "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$ViMoveMode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DELETE", "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$ViMoveMode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHANGE", "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$ViMoveMode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$ViMoveMode;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$ViMoveMode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/org/jline/reader/impl/LineReaderImpl$ViMoveMode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$ViMoveMode;"));
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$ViMoveMode;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.ViMoveMode NORMAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.ViMoveMode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$ViMoveMode;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.ViMoveMode YANK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.ViMoveMode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$ViMoveMode;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.ViMoveMode DELETE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.ViMoveMode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$ViMoveMode;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.ViMoveMode CHANGE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.ViMoveMode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$ViMoveMode;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.ViMoveMode> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.ViMoveMode>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ViMoveMode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ViMoveMode(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$ViMoveMode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$ViMoveMode;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.ViMoveMode> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.ViMoveMode>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/org/jline/reader/impl/LineReaderImpl$ViMoveMode;", "public static")]
		public static Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.ViMoveMode valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.ViMoveMode>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$ViMoveMode;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.ViMoveMode> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.ViMoveMode>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;", "protected static final")]
	public partial class State
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static State()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NORMAL", "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DONE", "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IGNORE", "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EOF", "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTERRUPT", "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;"));
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.State NORMAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.State>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.State DONE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.State>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.State IGNORE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.State>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.State EOF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.State>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.State INTERRUPT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.State>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.State> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.State>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public State(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public State(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.State> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.State>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;", "public static")]
		public static Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.State valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.State>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$State;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.State> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.State>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$Pair;", "static")]
	public partial class Pair
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Pair()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$Pair;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "u", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "v", "Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getV", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getU", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "final")]
		public Dova.JDK.java.lang.Object u_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "final")]
		public Dova.JDK.java.lang.Object v_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Pair(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)V", "public")]
		public Pair(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$Pair;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object getV()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object getU()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$TerminalLine;", "private static")]
	public partial class TerminalLine
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TerminalLine()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$TerminalLine;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "endLine", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "startPos", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartPos", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndLine", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String endLine_Property
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

		[JniSignatureAttribute("I", "private")]
		public int startPos_Property
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
		public TerminalLine(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;II)V", "public")]
		public TerminalLine(Dova.JDK.java.lang.String arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$TerminalLine;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int getStartPos()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getEndLine()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;", "protected static final")]
	public partial class CompletionType
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CompletionType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Expand", "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ExpandComplete", "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Complete", "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "List", "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;"));
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.CompletionType Expand_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.CompletionType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.CompletionType ExpandComplete_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.CompletionType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.CompletionType Complete_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.CompletionType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.CompletionType List_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.CompletionType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.CompletionType> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.CompletionType>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CompletionType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public CompletionType(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.CompletionType> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.CompletionType>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;", "public static")]
		public static Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.CompletionType valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.CompletionType>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletionType;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.CompletionType> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.CompletionType>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$PostResult;", "protected static")]
	public partial class PostResult
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PostResult()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$PostResult;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "post", "Ljdk/internal/org/jline/utils/AttributedString;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lines", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selectedLine", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/org/jline/utils/AttributedString;II)V"));
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/AttributedString;", "final")]
		public Dova.JDK.jdk.@internal.org.jline.utils.AttributedString post_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "final")]
		public int lines_Property
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

		[JniSignatureAttribute("I", "final")]
		public int selectedLine_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PostResult(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/org/jline/utils/AttributedString;II)V", "public")]
		public PostResult(Dova.JDK.jdk.@internal.org.jline.utils.AttributedString arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$PostResult;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$MenuSupport;", "private")]
	public partial class MenuSupport
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.function.Supplier
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MenuSupport()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$MenuSupport;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "possible", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "escaper", "Ljava/util/function/BiFunction;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selection", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "topLine", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "word", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "computed", "Ljdk/internal/org/jline/utils/AttributedString;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lines", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "columns", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "completed", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/org/jline/reader/impl/LineReaderImpl;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/org/jline/reader/impl/LineReaderImpl;Ljava/util/List;Ljava/lang/String;Ljava/util/function/BiFunction;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "()Ljdk/internal/org/jline/utils/AttributedString;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "previous", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "left", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "right", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "major", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minor", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "up", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "down", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "completion", "()Ljdk/internal/org/jline/reader/Candidate;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "final")]
		public Dova.JDK.java.util.List possible_Property
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

		[JniSignatureAttribute("Ljava/util/function/BiFunction;", "final")]
		public Dova.JDK.java.util.function.BiFunction escaper_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiFunction>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int selection_Property
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

		[JniSignatureAttribute("I", "")]
		public int topLine_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String word_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/AttributedString;", "")]
		public Dova.JDK.jdk.@internal.org.jline.utils.AttributedString computed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int lines_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int columns_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String completed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl;", "final")]
		public Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MenuSupport(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/impl/LineReaderImpl;Ljava/util/List;Ljava/lang/String;Ljava/util/function/BiFunction;)V", "public")]
		public MenuSupport(Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.function.BiFunction arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$MenuSupport;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/AttributedString;", "public")]
		public Dova.JDK.jdk.@internal.org.jline.utils.AttributedString get_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.AttributedString>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object get_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()V", "private")]
		public void update()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void next()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void previous()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void left()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void right()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("(I)V", "private")]
		public void major(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(I)V", "private")]
		public void minor(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void up()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void down()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
		}

		[JniSignatureAttribute("()Ljdk/internal/org/jline/reader/Candidate;", "public")]
		public Dova.JDK.jdk.@internal.org.jline.reader.Candidate completion()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.Candidate>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletingWord;", "private static")]
	public partial class CompletingWord
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.org.jline.reader.CompletingParsedLine
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CompletingWord()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletingWord;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "word", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "line", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "escape", "(Ljava/lang/CharSequence;Z)Ljava/lang/CharSequence;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cursor", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "words", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "word", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rawWordCursor", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rawWordLength", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wordIndex", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wordCursor", "()I"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String word_Property
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
		public CompletingWord(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public CompletingWord(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$CompletingWord;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String line()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/CharSequence;Z)Ljava/lang/CharSequence;", "public")]
		public Dova.JDK.java.lang.CharSequence escape(Dova.JDK.java.lang.CharSequence arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.CharSequence>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int cursor()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List words()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String word()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int rawWordCursor()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int rawWordLength()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int wordIndex()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int wordCursor()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$BellType;", "protected static final")]
	public partial class BellType
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BellType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$BellType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NONE", "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$BellType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AUDIBLE", "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$BellType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VISIBLE", "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$BellType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$BellType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$BellType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/org/jline/reader/impl/LineReaderImpl$BellType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$BellType;"));
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$BellType;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.BellType NONE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.BellType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$BellType;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.BellType AUDIBLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.BellType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl$BellType;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.BellType VISIBLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.BellType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$BellType;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.BellType> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.BellType>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BellType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public BellType(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/reader/impl/LineReaderImpl$BellType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$BellType;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.BellType> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.BellType>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/org/jline/reader/impl/LineReaderImpl$BellType;", "public static")]
		public static Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.BellType valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.BellType>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/org/jline/reader/impl/LineReaderImpl$BellType;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.BellType> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl.BellType>>(ret);
		}
	}
}
