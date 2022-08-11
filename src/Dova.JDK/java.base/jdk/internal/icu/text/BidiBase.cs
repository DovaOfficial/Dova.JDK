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

namespace Dova.JDK.jdk.@internal.icu.text;

[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase;", "public")]
public partial class BidiBase
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BidiBase()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/icu/text/BidiBase;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEVEL_DEFAULT_LTR", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEVEL_DEFAULT_RTL", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_EXPLICIT_LEVEL", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEVEL_OVERRIDE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAP_NOWHERE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LTR", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RTL", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MIXED", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KEEP_BASE_COMBINING", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DO_MIRRORING", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSERT_LRM_FOR_NUMERIC", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REMOVE_BIDI_CONTROLS", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OUTPUT_REVERSE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REORDER_DEFAULT", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REORDER_NUMBERS_SPECIAL", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REORDER_GROUP_NUMBERS_WITH_R", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REORDER_RUNS_ONLY", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REORDER_INVERSE_NUMBERS_AS_L", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REORDER_INVERSE_LIKE_DIRECT", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REORDER_INVERSE_FOR_NUMBERS_SPECIAL", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REORDER_LAST_LOGICAL_TO_VISUAL", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OPTION_INSERT_MARKS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OPTION_REMOVE_CONTROLS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OPTION_STREAMING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "L", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "R", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EN", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ES", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ET", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AN", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "B", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "S", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WS", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ON", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LRE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LRO", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AL", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RLE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RLO", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PDF", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NSM", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BN", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FSI", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LRI", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RLI", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PDI", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENL", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENR", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHAR_DIRECTION_COUNT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BIDI_PAIRED_BRACKET_TYPE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIMPLE_PARAS_COUNT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CR", "C"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LF", "C"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LRM_BEFORE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LRM_AFTER", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RLM_BEFORE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RLM_AFTER", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FOUND_L", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FOUND_R", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISOLATE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paraBidi", "Ljdk/internal/icu/text/BidiBase;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bdp", "Ljdk/internal/icu/impl/UBiDiProps;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "text", "[C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "originalLength", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "length", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resultLength", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mayAllocateText", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mayAllocateRuns", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dirPropsMemory", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "levelsMemory", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dirProps", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "levels", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isInverse", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reorderingMode", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reorderingOptions", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "orderParagraphsLTR", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paraLevel", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultParaLevel", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "impTabPair", "Ljdk/internal/icu/text/BidiBase$ImpTabPair;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "direction", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flags", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastArabicPos", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "trailingWSStart", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paraCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paras_limit", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paras_level", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "runCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "runsMemory", "[Ljdk/internal/icu/text/BidiRun;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "runs", "[Ljdk/internal/icu/text/BidiRun;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "simpleRuns", "[Ljdk/internal/icu/text/BidiRun;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isolates", "[Ljdk/internal/icu/text/BidiBase$Isolate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isolateCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "logicalToVisualRunsMap", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isGoodLogicalToVisualRunsMap", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "insertPoints", "Ljdk/internal/icu/text/BidiBase$InsertPoints;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "controlCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DirPropFlagMultiRuns", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DirPropFlagLR", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DirPropFlagE", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DirPropFlagO", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MASK_LTR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MASK_RTL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MASK_R_AL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MASK_EXPLICIT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MASK_BN_EXPLICIT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MASK_ISO", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MASK_B_S", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MASK_WS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MASK_POSSIBLE_N", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MASK_EMBEDDING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOT_SEEKING_STRONG", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SEEKING_STRONG_FOR_PARA", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SEEKING_STRONG_FOR_FSI", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOOKING_FOR_PDI", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMPTABPROPS_COLUMNS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMPTABPROPS_RES", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "groupProp", "[S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "_L", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "_R", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "_EN", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "_AN", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "_ON", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "_S", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "_B", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impTabProps", "[[S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMPTABLEVELS_COLUMNS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMPTABLEVELS_RES", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impTabL_DEFAULT", "[[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impTabR_DEFAULT", "[[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impAct0", "[S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impTab_DEFAULT", "Ljdk/internal/icu/text/BidiBase$ImpTabPair;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impTabL_NUMBERS_SPECIAL", "[[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impTab_NUMBERS_SPECIAL", "Ljdk/internal/icu/text/BidiBase$ImpTabPair;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impTabL_GROUP_NUMBERS_WITH_R", "[[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impTabR_GROUP_NUMBERS_WITH_R", "[[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impTab_GROUP_NUMBERS_WITH_R", "Ljdk/internal/icu/text/BidiBase$ImpTabPair;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impTabL_INVERSE_NUMBERS_AS_L", "[[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impTabR_INVERSE_NUMBERS_AS_L", "[[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impTab_INVERSE_NUMBERS_AS_L", "Ljdk/internal/icu/text/BidiBase$ImpTabPair;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impTabR_INVERSE_LIKE_DIRECT", "[[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impAct1", "[S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impTab_INVERSE_LIKE_DIRECT", "Ljdk/internal/icu/text/BidiBase$ImpTabPair;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impTabL_INVERSE_LIKE_DIRECT_WITH_MARKS", "[[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impTabR_INVERSE_LIKE_DIRECT_WITH_MARKS", "[[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impAct2", "[S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impAct3", "[S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impTab_INVERSE_LIKE_DIRECT_WITH_MARKS", "Ljdk/internal/icu/text/BidiBase$ImpTabPair;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impTab_INVERSE_FOR_NUMBERS_SPECIAL", "Ljdk/internal/icu/text/BidiBase$ImpTabPair;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impTabL_INVERSE_FOR_NUMBERS_SPECIAL_WITH_MARKS", "[[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "impTab_INVERSE_FOR_NUMBERS_SPECIAL_WITH_MARKS", "Ljdk/internal/icu/text/BidiBase$ImpTabPair;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIRSTALLOC", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTION_DEFAULT_RIGHT_TO_LEFT", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(II)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([CI[BIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirection", "()B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DirPropFlag", "(B)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DirPropFlagLR", "(B)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DirPropFlagE", "(B)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DirPropFlagO", "(B)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInitialDirPropsMemory", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInitialLevelsMemory", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInitialRunsMemory", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemory", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Class;ZI)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirPropsMemory", "(ZI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirPropsMemory", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLevelsMemory", "(ZI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLevelsMemory", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRunsMemory", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRunsMemory", "(ZI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInverse", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IsDefaultLevel", "(B)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCustomizedClass", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IsBidiControlChar", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkParaCount", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "orderParagraphsLTR", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isMixed", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRunStart", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRunLimit", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "GetParaLevelAt", "(I)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NoOverride", "(B)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fixN0c", "(Ljdk/internal/icu/text/BidiBase$BracketData;IIB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bracketProcessClosing", "(Ljdk/internal/icu/text/BidiBase$BracketData;II)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bracketAddOpening", "(Ljdk/internal/icu/text/BidiBase$BracketData;CI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DirFromStrong", "(B)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "directionFromFlags", "()B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bracketInit", "(Ljdk/internal/icu/text/BidiBase$BracketData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bracketProcessB", "(Ljdk/internal/icu/text/BidiBase$BracketData;B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bracketProcessChar", "(Ljdk/internal/icu/text/BidiBase$BracketData;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bracketProcessBoundary", "(Ljdk/internal/icu/text/BidiBase$BracketData;IBB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bracketProcessLRI_RLI", "(Ljdk/internal/icu/text/BidiBase$BracketData;B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bracketProcessPDI", "(Ljdk/internal/icu/text/BidiBase$BracketData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "GetState", "(B)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "GetAction", "(B)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLevelsOutsideIsolates", "(IIB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processPropertySeq", "(Ljdk/internal/icu/text/BidiBase$LevState;SII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "GetStateProps", "(S)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "GetActionProps", "(S)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPara", "([CB[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPara", "(Ljava/lang/String;B[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPara", "(Ljava/text/AttributedCharacterIterator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeReordered", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisualMap", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Bidi_Abs", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Bidi_Min", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verifyRange", "(III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setParaRunsOnly", "([CB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setParaSuccess", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirProps", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveExplicitLevels", "()B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkExplicitLevels", "()B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "GetLRFromLevel", "(B)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveImplicitLevels", "(IISS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adjustWSLevels", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verifyValidParaOrLine", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verifyValidPara", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLine", "(Ljava/text/Bidi;Ljdk/internal/icu/text/BidiBase;Ljava/text/Bidi;Ljdk/internal/icu/text/BidiBase;II)Ljava/text/Bidi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaseLevel", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLevelAt", "(I)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisualRun", "(I)Ljdk/internal/icu/text/BidiRun;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "countRuns", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "reorderVisual", "([B)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRightToLeft", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParaLevel", "()B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLogicalToVisualRunsMap", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "testDirPropFlagAt", "(II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "baseIsLeftToRight", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRunLevel", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "requiresBidi", "([CII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "reorderVisually", "([BI[Ljava/lang/Object;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLevels", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPoint", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLeftToRight", "()Z"));
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte LEVEL_DEFAULT_LTR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte LEVEL_DEFAULT_RTL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte MAX_EXPLICIT_LEVEL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte LEVEL_OVERRIDE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int MAP_NOWHERE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte LTR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte RTL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte MIXED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short KEEP_BASE_COMBINING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DO_MIRRORING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short INSERT_LRM_FOR_NUMERIC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short REMOVE_BIDI_CONTROLS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short OUTPUT_REVERSE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("S", "private static final")]
	public static short REORDER_DEFAULT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("S", "private static final")]
	public static short REORDER_NUMBERS_SPECIAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("S", "private static final")]
	public static short REORDER_GROUP_NUMBERS_WITH_R_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("S", "static final")]
	public static short REORDER_RUNS_ONLY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("S", "static final")]
	public static short REORDER_INVERSE_NUMBERS_AS_L_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("S", "static final")]
	public static short REORDER_INVERSE_LIKE_DIRECT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("S", "static final")]
	public static short REORDER_INVERSE_FOR_NUMBERS_SPECIAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("S", "private static final")]
	public static short REORDER_LAST_LOGICAL_TO_VISUAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int OPTION_INSERT_MARKS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int OPTION_REMOVE_CONTROLS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int OPTION_STREAMING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte L_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte R_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte EN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte ES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[27]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[27], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte ET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte AN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte CS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte B_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[31]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[31], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte S_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[32]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[32], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte WS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[33]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[33], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte ON_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[34]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[34], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte LRE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[35]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[35], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte LRO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[36]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[36], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte AL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[37]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[37], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte RLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[38]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[38], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte RLO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[39]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[39], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte PDF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[40]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[40], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte NSM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[41]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[41], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte BN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[42]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[42], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte FSI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[43]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[43], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte LRI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[44]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[44], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte RLI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[45]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[45], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte PDI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[46]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[46], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte ENL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[47]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[47], value);
		}
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte ENR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[48]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[48], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CHAR_DIRECTION_COUNT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[49]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[49], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int BIDI_PAIRED_BRACKET_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[50]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[50], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int SIMPLE_PARAS_COUNT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[51]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[51], value);
		}
	}

	[JniSignatureAttribute("C", "private static final")]
	public static char CR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[52]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[52], value);
		}
	}

	[JniSignatureAttribute("C", "private static final")]
	public static char LF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[53]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[53], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int LRM_BEFORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[54]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[54], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int LRM_AFTER_Property
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
	public static int RLM_BEFORE_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int RLM_AFTER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[57]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[57], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte FOUND_L_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[58]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[58], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte FOUND_R_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[59]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[59], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int ISOLATE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[60]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[60], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase;", "")]
	public Dova.JDK.jdk.@internal.icu.text.BidiBase paraBidi_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[61]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.BidiBase>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[61], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/icu/impl/UBiDiProps;", "final")]
	public Dova.JDK.jdk.@internal.icu.impl.UBiDiProps bdp_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[62]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.impl.UBiDiProps>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[62], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[C", "")]
	public JavaArray<char> text_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[63]);
			return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[63], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int originalLength_Property
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

	[JniSignatureAttribute("I", "public")]
	public int length_Property
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

	[JniSignatureAttribute("I", "")]
	public int resultLength_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[66]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[66], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool mayAllocateText_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[67]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[67], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool mayAllocateRuns_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[68]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[68], value);
		}
	}

	[JniSignatureAttribute("[B", "")]
	public JavaArray<byte> dirPropsMemory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[69]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[69], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "")]
	public JavaArray<byte> levelsMemory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[70]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[70], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "")]
	public JavaArray<byte> dirProps_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[71]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[71], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "")]
	public JavaArray<byte> levels_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[72]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[72], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool isInverse_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[73]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[73], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int reorderingMode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[74]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[74], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int reorderingOptions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[75]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[75], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool orderParagraphsLTR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[76]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[76], value);
		}
	}

	[JniSignatureAttribute("B", "")]
	public byte paraLevel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[77]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[77], value);
		}
	}

	[JniSignatureAttribute("B", "")]
	public byte defaultParaLevel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[78]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[78], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase$ImpTabPair;", "")]
	public Dova.JDK.jdk.@internal.icu.text.BidiBase.ImpTabPair impTabPair_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[79]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.BidiBase.ImpTabPair>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[79], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("B", "")]
	public byte direction_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[80]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[80], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int flags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[81]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[81], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int lastArabicPos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[82]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[82], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int trailingWSStart_Property
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

	[JniSignatureAttribute("I", "")]
	public int paraCount_Property
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

	[JniSignatureAttribute("[I", "")]
	public JavaArray<int> paras_limit_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[85]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[85], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "")]
	public JavaArray<byte> paras_level_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[86]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[86], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int runCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[87]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[87], value);
		}
	}

	[JniSignatureAttribute("[Ljdk/internal/icu/text/BidiRun;", "")]
	public JavaArray<Dova.JDK.jdk.@internal.icu.text.BidiRun> runsMemory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[88]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.icu.text.BidiRun>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[88], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljdk/internal/icu/text/BidiRun;", "")]
	public JavaArray<Dova.JDK.jdk.@internal.icu.text.BidiRun> runs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[89]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.icu.text.BidiRun>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[89], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljdk/internal/icu/text/BidiRun;", "")]
	public JavaArray<Dova.JDK.jdk.@internal.icu.text.BidiRun> simpleRuns_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[90]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.icu.text.BidiRun>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[90], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljdk/internal/icu/text/BidiBase$Isolate;", "")]
	public JavaArray<Dova.JDK.jdk.@internal.icu.text.BidiBase.Isolate> isolates_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[91]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.icu.text.BidiBase.Isolate>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[91], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int isolateCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[92]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[92], value);
		}
	}

	[JniSignatureAttribute("[I", "")]
	public JavaArray<int> logicalToVisualRunsMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[93]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[93], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool isGoodLogicalToVisualRunsMap_Property
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

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase$InsertPoints;", "")]
	public Dova.JDK.jdk.@internal.icu.text.BidiBase.InsertPoints insertPoints_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[95]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.BidiBase.InsertPoints>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[95], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int controlCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[96]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[96], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int DirPropFlagMultiRuns_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[97]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[97], value);
		}
	}

	[JniSignatureAttribute("[I", "static final")]
	public static JavaArray<int> DirPropFlagLR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[98]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[98], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "static final")]
	public static JavaArray<int> DirPropFlagE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[99]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[99], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "static final")]
	public static JavaArray<int> DirPropFlagO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[100]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[100], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int MASK_LTR_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int MASK_RTL_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int MASK_R_AL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[103]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[103], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MASK_EXPLICIT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[104]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[104], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MASK_BN_EXPLICIT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[105]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[105], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MASK_ISO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[106]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[106], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MASK_B_S_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[107]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[107], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int MASK_WS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[108]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[108], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MASK_POSSIBLE_N_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[109]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[109], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MASK_EMBEDDING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[110]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[110], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int NOT_SEEKING_STRONG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[111]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[111], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int SEEKING_STRONG_FOR_PARA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[112]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[112], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int SEEKING_STRONG_FOR_FSI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[113]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[113], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int LOOKING_FOR_PDI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[114]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[114], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int IMPTABPROPS_COLUMNS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[115]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[115], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int IMPTABPROPS_RES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[116]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[116], value);
		}
	}

	[JniSignatureAttribute("[S", "private static final")]
	public static JavaArray<short> groupProp_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[117]);
			return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[117], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("S", "private static final")]
	public static short _L_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[118]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[118], value);
		}
	}

	[JniSignatureAttribute("S", "private static final")]
	public static short _R_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[119]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[119], value);
		}
	}

	[JniSignatureAttribute("S", "private static final")]
	public static short _EN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[120]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[120], value);
		}
	}

	[JniSignatureAttribute("S", "private static final")]
	public static short _AN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[121]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[121], value);
		}
	}

	[JniSignatureAttribute("S", "private static final")]
	public static short _ON_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[122]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[122], value);
		}
	}

	[JniSignatureAttribute("S", "private static final")]
	public static short _S_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[123]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[123], value);
		}
	}

	[JniSignatureAttribute("S", "private static final")]
	public static short _B_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[124]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[124], value);
		}
	}

	[JniSignatureAttribute("[[S", "private static final")]
	public static JavaArray<JavaArray<short>> impTabProps_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[125]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<short>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[125], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int IMPTABLEVELS_COLUMNS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[126]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[126], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int IMPTABLEVELS_RES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[127]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[127], value);
		}
	}

	[JniSignatureAttribute("[[B", "private static final")]
	public static JavaArray<JavaArray<byte>> impTabL_DEFAULT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[128]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<byte>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[128], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[B", "private static final")]
	public static JavaArray<JavaArray<byte>> impTabR_DEFAULT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[129]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<byte>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[129], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[S", "private static final")]
	public static JavaArray<short> impAct0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[130]);
			return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[130], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase$ImpTabPair;", "private static final")]
	public static Dova.JDK.jdk.@internal.icu.text.BidiBase.ImpTabPair impTab_DEFAULT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[131]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.BidiBase.ImpTabPair>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[131], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[B", "private static final")]
	public static JavaArray<JavaArray<byte>> impTabL_NUMBERS_SPECIAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[132]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<byte>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[132], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase$ImpTabPair;", "private static final")]
	public static Dova.JDK.jdk.@internal.icu.text.BidiBase.ImpTabPair impTab_NUMBERS_SPECIAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[133]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.BidiBase.ImpTabPair>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[133], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[B", "private static final")]
	public static JavaArray<JavaArray<byte>> impTabL_GROUP_NUMBERS_WITH_R_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[134]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<byte>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[134], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[B", "private static final")]
	public static JavaArray<JavaArray<byte>> impTabR_GROUP_NUMBERS_WITH_R_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[135]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<byte>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[135], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase$ImpTabPair;", "private static final")]
	public static Dova.JDK.jdk.@internal.icu.text.BidiBase.ImpTabPair impTab_GROUP_NUMBERS_WITH_R_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[136]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.BidiBase.ImpTabPair>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[136], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[B", "private static final")]
	public static JavaArray<JavaArray<byte>> impTabL_INVERSE_NUMBERS_AS_L_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[137]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<byte>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[137], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[B", "private static final")]
	public static JavaArray<JavaArray<byte>> impTabR_INVERSE_NUMBERS_AS_L_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[138]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<byte>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[138], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase$ImpTabPair;", "private static final")]
	public static Dova.JDK.jdk.@internal.icu.text.BidiBase.ImpTabPair impTab_INVERSE_NUMBERS_AS_L_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[139]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.BidiBase.ImpTabPair>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[139], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[B", "private static final")]
	public static JavaArray<JavaArray<byte>> impTabR_INVERSE_LIKE_DIRECT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[140]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<byte>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[140], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[S", "private static final")]
	public static JavaArray<short> impAct1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[141]);
			return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[141], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase$ImpTabPair;", "private static final")]
	public static Dova.JDK.jdk.@internal.icu.text.BidiBase.ImpTabPair impTab_INVERSE_LIKE_DIRECT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[142]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.BidiBase.ImpTabPair>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[142], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[B", "private static final")]
	public static JavaArray<JavaArray<byte>> impTabL_INVERSE_LIKE_DIRECT_WITH_MARKS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[143]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<byte>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[143], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[B", "private static final")]
	public static JavaArray<JavaArray<byte>> impTabR_INVERSE_LIKE_DIRECT_WITH_MARKS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[144]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<byte>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[144], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[S", "private static final")]
	public static JavaArray<short> impAct2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[145]);
			return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[145], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[S", "private static final")]
	public static JavaArray<short> impAct3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[146]);
			return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[146], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase$ImpTabPair;", "private static final")]
	public static Dova.JDK.jdk.@internal.icu.text.BidiBase.ImpTabPair impTab_INVERSE_LIKE_DIRECT_WITH_MARKS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[147]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.BidiBase.ImpTabPair>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[147], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase$ImpTabPair;", "private static final")]
	public static Dova.JDK.jdk.@internal.icu.text.BidiBase.ImpTabPair impTab_INVERSE_FOR_NUMBERS_SPECIAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[148]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.BidiBase.ImpTabPair>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[148], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[B", "private static final")]
	public static JavaArray<JavaArray<byte>> impTabL_INVERSE_FOR_NUMBERS_SPECIAL_WITH_MARKS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[149]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<byte>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[149], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase$ImpTabPair;", "private static final")]
	public static Dova.JDK.jdk.@internal.icu.text.BidiBase.ImpTabPair impTab_INVERSE_FOR_NUMBERS_SPECIAL_WITH_MARKS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[150]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.BidiBase.ImpTabPair>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[150], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int FIRSTALLOC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[151]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[151], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int DIRECTION_DEFAULT_RIGHT_TO_LEFT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[152]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[152], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BidiBase(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(II)V", "public")]
	public BidiBase(int arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("([CI[BIII)V", "public")]
	public BidiBase(JavaArray<char> arg0, int arg1, JavaArray<byte> arg2, int arg3, int arg4, int arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/icu/text/BidiBase;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()B", "public")]
	public byte getDirection()
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(B)I", "static")]
	public static int DirPropFlag(byte arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(B)I", "static final")]
	public static int DirPropFlagLR(byte arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(B)I", "static final")]
	public static int DirPropFlagE(byte arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(B)I", "static final")]
	public static int DirPropFlagO(byte arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void getInitialDirPropsMemory(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void getInitialLevelsMemory(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void getInitialRunsMemory(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Class;ZI)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object getMemory(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Class arg2, bool arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ZI)V", "private")]
	public void getDirPropsMemory(bool arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(I)V", "")]
	public void getDirPropsMemory(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(ZI)V", "private")]
	public void getLevelsMemory(bool arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("(I)V", "")]
	public void getLevelsMemory(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(I)V", "")]
	public void getRunsMemory(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(ZI)V", "private")]
	public void getRunsMemory(bool arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isInverse()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("(B)Z", "private static")]
	public static bool IsDefaultLevel(byte arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getCustomizedClass(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "static")]
	public static bool IsBidiControlChar(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void checkParaCount()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21]);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void orderParagraphsLTR(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isMixed()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getRunStart(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getRunLimit(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)B", "")]
	public byte GetParaLevelAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return ret;
	}

	[JniSignatureAttribute("(B)B", "static final")]
	public static byte NoOverride(byte arg0)
	{
		var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[27], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/BidiBase$BracketData;IIB)V", "private")]
	public void fixN0c(Dova.JDK.jdk.@internal.icu.text.BidiBase.BracketData arg0, int arg1, int arg2, byte arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/BidiBase$BracketData;II)B", "private")]
	public byte bracketProcessClosing(Dova.JDK.jdk.@internal.icu.text.BidiBase.BracketData arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/BidiBase$BracketData;CI)V", "private")]
	public void bracketAddOpening(Dova.JDK.jdk.@internal.icu.text.BidiBase.BracketData arg0, char arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(B)B", "static final")]
	public static byte DirFromStrong(byte arg0)
	{
		var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[31], arg0);
		return ret;
	}

	[JniSignatureAttribute("()B", "private")]
	public byte directionFromFlags()
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[32]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/BidiBase$BracketData;)V", "private")]
	public void bracketInit(Dova.JDK.jdk.@internal.icu.text.BidiBase.BracketData arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/BidiBase$BracketData;B)V", "private")]
	public void bracketProcessB(Dova.JDK.jdk.@internal.icu.text.BidiBase.BracketData arg0, byte arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/BidiBase$BracketData;I)V", "private")]
	public void bracketProcessChar(Dova.JDK.jdk.@internal.icu.text.BidiBase.BracketData arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/BidiBase$BracketData;IBB)V", "private")]
	public void bracketProcessBoundary(Dova.JDK.jdk.@internal.icu.text.BidiBase.BracketData arg0, int arg1, byte arg2, byte arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/BidiBase$BracketData;B)V", "private")]
	public void bracketProcessLRI_RLI(Dova.JDK.jdk.@internal.icu.text.BidiBase.BracketData arg0, byte arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/BidiBase$BracketData;)V", "private")]
	public void bracketProcessPDI(Dova.JDK.jdk.@internal.icu.text.BidiBase.BracketData arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("(B)S", "private static")]
	public static short GetState(byte arg0)
	{
		var ret = DovaVM.Runtime.CallStaticShortMethodA(ClassRefPtr, MethodPtrs[39], arg0);
		return ret;
	}

	[JniSignatureAttribute("(B)S", "private static")]
	public static short GetAction(byte arg0)
	{
		var ret = DovaVM.Runtime.CallStaticShortMethodA(ClassRefPtr, MethodPtrs[40], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IIB)V", "private")]
	public void setLevelsOutsideIsolates(int arg0, int arg1, byte arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljdk/internal/icu/text/BidiBase$LevState;SII)V", "private")]
	public void processPropertySeq(Dova.JDK.jdk.@internal.icu.text.BidiBase.LevState arg0, short arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(S)S", "private static")]
	public static short GetStateProps(short arg0)
	{
		var ret = DovaVM.Runtime.CallStaticShortMethodA(ClassRefPtr, MethodPtrs[43], arg0);
		return ret;
	}

	[JniSignatureAttribute("(S)S", "private static")]
	public static short GetActionProps(short arg0)
	{
		var ret = DovaVM.Runtime.CallStaticShortMethodA(ClassRefPtr, MethodPtrs[44], arg0);
		return ret;
	}

	[JniSignatureAttribute("([CB[B)V", "")]
	public void setPara(JavaArray<char> arg0, byte arg1, JavaArray<byte> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;B[B)V", "")]
	public void setPara(Dova.JDK.java.lang.String arg0, byte arg1, JavaArray<byte> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/text/AttributedCharacterIterator;)V", "public")]
	public void setPara(Dova.JDK.java.text.AttributedCharacterIterator arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String writeReordered(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()[I", "private")]
	public JavaArray<int> getVisualMap()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(I)I", "private")]
	public int Bidi_Abs(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "private")]
	public int Bidi_Min(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(III)V", "")]
	public void verifyRange(int arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([CB)V", "")]
	public void setParaRunsOnly(JavaArray<char> arg0, byte arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "private")]
	public void setParaSuccess()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void getDirProps()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55]);
	}

	[JniSignatureAttribute("()B", "private")]
	public byte resolveExplicitLevels()
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[56]);
		return ret;
	}

	[JniSignatureAttribute("()B", "private")]
	public byte checkExplicitLevels()
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[57]);
		return ret;
	}

	[JniSignatureAttribute("(B)B", "private static")]
	public static byte GetLRFromLevel(byte arg0)
	{
		var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[58], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IISS)V", "private")]
	public void resolveImplicitLevels(int arg0, int arg1, short arg2, short arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()V", "private")]
	public void adjustWSLevels()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60]);
	}

	[JniSignatureAttribute("()V", "")]
	public void verifyValidParaOrLine()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[61]);
	}

	[JniSignatureAttribute("()V", "")]
	public void verifyValidPara()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[62]);
	}

	[JniSignatureAttribute("(Ljava/text/Bidi;Ljdk/internal/icu/text/BidiBase;Ljava/text/Bidi;Ljdk/internal/icu/text/BidiBase;II)Ljava/text/Bidi;", "public")]
	public Dova.JDK.java.text.Bidi setLine(Dova.JDK.java.text.Bidi arg0, Dova.JDK.jdk.@internal.icu.text.BidiBase arg1, Dova.JDK.java.text.Bidi arg2, Dova.JDK.jdk.@internal.icu.text.BidiBase arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.Bidi>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getBaseLevel()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[64]);
		return ret;
	}

	[JniSignatureAttribute("(I)B", "public")]
	public byte getLevelAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljdk/internal/icu/text/BidiRun;", "")]
	public Dova.JDK.jdk.@internal.icu.text.BidiRun getVisualRun(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.icu.text.BidiRun>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int countRuns()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[67]);
		return ret;
	}

	[JniSignatureAttribute("([B)[I", "private static")]
	public static JavaArray<int> reorderVisual(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[68], arg0);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isRightToLeft()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[69]);
		return ret;
	}

	[JniSignatureAttribute("()B", "public")]
	public byte getParaLevel()
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[70]);
		return ret;
	}

	[JniSignatureAttribute("()V", "")]
	public void getLogicalToVisualRunsMap()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[71]);
	}

	[JniSignatureAttribute("(II)Z", "")]
	public bool testDirPropFlagAt(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[72], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool baseIsLeftToRight()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[73]);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getRunLevel(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[74], arg0);
		return ret;
	}

	[JniSignatureAttribute("([CII)Z", "public static")]
	public static bool requiresBidi(JavaArray<char> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[75], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([BI[Ljava/lang/Object;II)V", "public static")]
	public static void reorderVisually(JavaArray<byte> arg0, int arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[76], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()[B", "")]
	public JavaArray<byte> getLevels()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(II)V", "private")]
	public void addPoint(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[78], arg0, arg1);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isLeftToRight()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[79]);
		return ret;
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase$InsertPoints;", "static")]
	public partial class InsertPoints
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InsertPoints()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/icu/text/BidiBase$InsertPoints;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "size", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "confirmed", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "points", "[Ljdk/internal/icu/text/BidiBase$Point;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "")]
		public int size_Property
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

		[JniSignatureAttribute("I", "")]
		public int confirmed_Property
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

		[JniSignatureAttribute("[Ljdk/internal/icu/text/BidiBase$Point;", "")]
		public JavaArray<Dova.JDK.jdk.@internal.icu.text.BidiBase.Point> points_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.icu.text.BidiBase.Point>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InsertPoints(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public InsertPoints() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/icu/text/BidiBase$InsertPoints;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase$BracketData;", "static")]
	public partial class BracketData
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BracketData()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/icu/text/BidiBase$BracketData;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "openings", "[Ljdk/internal/icu/text/BidiBase$Opening;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isoRunLast", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isoRuns", "[Ljdk/internal/icu/text/BidiBase$IsoRun;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isNumbersSpecial", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("[Ljdk/internal/icu/text/BidiBase$Opening;", "")]
		public JavaArray<Dova.JDK.jdk.@internal.icu.text.BidiBase.Opening> openings_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.icu.text.BidiBase.Opening>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int isoRunLast_Property
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

		[JniSignatureAttribute("[Ljdk/internal/icu/text/BidiBase$IsoRun;", "")]
		public JavaArray<Dova.JDK.jdk.@internal.icu.text.BidiBase.IsoRun> isoRuns_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.icu.text.BidiBase.IsoRun>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool isNumbersSpecial_Property
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
		public BracketData(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public BracketData() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/icu/text/BidiBase$BracketData;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase$IsoRun;", "static")]
	public partial class IsoRun
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IsoRun()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/icu/text/BidiBase$IsoRun;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contextPos", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "start", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "limit", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "level", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastStrong", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastBase", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contextDir", "B"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "")]
		public int contextPos_Property
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

		[JniSignatureAttribute("S", "")]
		public short start_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("S", "")]
		public short limit_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("B", "")]
		public byte level_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("B", "")]
		public byte lastStrong_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("B", "")]
		public byte lastBase_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("B", "")]
		public byte contextDir_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IsoRun(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public IsoRun() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/icu/text/BidiBase$IsoRun;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase$Opening;", "static")]
	public partial class Opening
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Opening()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/icu/text/BidiBase$Opening;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "position", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "match", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contextPos", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flags", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contextDir", "B"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "")]
		public int position_Property
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

		[JniSignatureAttribute("I", "")]
		public int match_Property
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

		[JniSignatureAttribute("I", "")]
		public int contextPos_Property
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

		[JniSignatureAttribute("S", "")]
		public short flags_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("B", "")]
		public byte contextDir_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Opening(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Opening() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/icu/text/BidiBase$Opening;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase$BidiPairedBracketType;", "public abstract static interface")]
	public partial interface BidiPairedBracketType
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BidiPairedBracketType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/icu/text/BidiBase$BidiPairedBracketType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NONE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OPEN", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLOSE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COUNT", "I"));
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int NONE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int OPEN_Property
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

		[JniSignatureAttribute("I", "public static final")]
		public static int CLOSE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int COUNT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
			}
		}
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase$Point;", "static")]
	public partial class Point
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Point()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/icu/text/BidiBase$Point;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pos", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flag", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "")]
		public int pos_Property
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

		[JniSignatureAttribute("I", "")]
		public int flag_Property
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
		public Point(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Point() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/icu/text/BidiBase$Point;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase$LevState;", "private static")]
	public partial class LevState
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LevState()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/icu/text/BidiBase$LevState;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "impTab", "[[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "impAct", "[S"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "startON", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "startL2EN", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastStrongRTL", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "runStart", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "state", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "runLevel", "B"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("[[B", "")]
		public JavaArray<JavaArray<byte>> impTab_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<JavaArray<byte>>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[S", "")]
		public JavaArray<short> impAct_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int startON_Property
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
		public int startL2EN_Property
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

		[JniSignatureAttribute("I", "")]
		public int lastStrongRTL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int runStart_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("S", "")]
		public short state_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("B", "")]
		public byte runLevel_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LevState(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public LevState() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/icu/text/BidiBase$LevState;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase$ImpTabPair;", "private static")]
	public partial class ImpTabPair
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ImpTabPair()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/icu/text/BidiBase$ImpTabPair;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "imptab", "[[[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "impact", "[[S"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([[B[[B[S[S)V"));
		}

		[JniSignatureAttribute("[[[B", "")]
		public JavaArray<JavaArray<JavaArray<byte>>> imptab_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<JavaArray<JavaArray<byte>>>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[[S", "")]
		public JavaArray<JavaArray<short>> impact_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<JavaArray<short>>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ImpTabPair(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([[B[[B[S[S)V", "")]
		public ImpTabPair(JavaArray<JavaArray<byte>> arg0, JavaArray<JavaArray<byte>> arg1, JavaArray<short> arg2, JavaArray<short> arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/icu/text/BidiBase$ImpTabPair;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase$Isolate;", "static")]
	public partial class Isolate
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Isolate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/icu/text/BidiBase$Isolate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "startON", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "start1", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stateImp", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "state", "S"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "")]
		public int startON_Property
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

		[JniSignatureAttribute("I", "")]
		public int start1_Property
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

		[JniSignatureAttribute("S", "")]
		public short stateImp_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("S", "")]
		public short state_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Isolate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Isolate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/icu/text/BidiBase$Isolate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase$TextAttributeConstants;", "private static")]
	public partial class TextAttributeConstants
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TextAttributeConstants()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/icu/text/BidiBase$TextAttributeConstants;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "jafa", "Ljdk/internal/access/JavaAWTFontAccess;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RUN_DIRECTION", "Ljava/text/AttributedCharacterIterator$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NUMERIC_SHAPING", "Ljava/text/AttributedCharacterIterator$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BIDI_EMBEDDING", "Ljava/text/AttributedCharacterIterator$Attribute;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RUN_DIRECTION_LTR", "Ljava/lang/Boolean;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTextAttribute", "(Ljava/lang/String;)Ljava/text/AttributedCharacterIterator$Attribute;"));
		}

		[JniSignatureAttribute("Ljdk/internal/access/JavaAWTFontAccess;", "static final")]
		public static Dova.JDK.jdk.@internal.access.JavaAWTFontAccess jafa_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaAWTFontAccess>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/text/AttributedCharacterIterator$Attribute;", "static final")]
		public static Dova.JDK.java.text.AttributedCharacterIterator.Attribute RUN_DIRECTION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.text.AttributedCharacterIterator.Attribute>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/text/AttributedCharacterIterator$Attribute;", "static final")]
		public static Dova.JDK.java.text.AttributedCharacterIterator.Attribute NUMERIC_SHAPING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.text.AttributedCharacterIterator.Attribute>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/text/AttributedCharacterIterator$Attribute;", "static final")]
		public static Dova.JDK.java.text.AttributedCharacterIterator.Attribute BIDI_EMBEDDING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.text.AttributedCharacterIterator.Attribute>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Boolean;", "static final")]
		public static Dova.JDK.java.lang.Boolean RUN_DIRECTION_LTR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TextAttributeConstants(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public TextAttributeConstants() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/icu/text/BidiBase$TextAttributeConstants;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/text/AttributedCharacterIterator$Attribute;", "private static")]
		public static Dova.JDK.java.text.AttributedCharacterIterator.Attribute getTextAttribute(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.text.AttributedCharacterIterator.Attribute>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/icu/text/BidiBase$NumericShapings;", "private static")]
	public partial class NumericShapings
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NumericShapings()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/icu/text/BidiBase$NumericShapings;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "jafa", "Ljdk/internal/access/JavaAWTFontAccess;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "shape", "(Ljava/lang/Object;[CII)V"));
		}

		[JniSignatureAttribute("Ljdk/internal/access/JavaAWTFontAccess;", "static final")]
		public static Dova.JDK.jdk.@internal.access.JavaAWTFontAccess jafa_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaAWTFontAccess>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NumericShapings(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public NumericShapings() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/icu/text/BidiBase$NumericShapings;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;[CII)V", "static")]
		public static void shape(Dova.JDK.java.lang.Object arg0, JavaArray<char> arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}
	}
}
