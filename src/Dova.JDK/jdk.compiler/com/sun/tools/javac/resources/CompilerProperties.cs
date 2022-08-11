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

namespace Dova.JDK.com.sun.tools.javac.resources;

[JniSignatureAttribute("Lcom/sun/tools/javac/resources/CompilerProperties;", "public")]
public partial class CompilerProperties
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CompilerProperties()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/resources/CompilerProperties;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CompilerProperties(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public CompilerProperties() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/resources/CompilerProperties;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("Lcom/sun/tools/javac/resources/CompilerProperties$Fragments;", "public static")]
	public partial class Fragments
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Fragments()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/resources/CompilerProperties$Fragments;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AccessorMethodCantThrowException", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AccessorMethodMustNotBeGeneric", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AccessorMethodMustNotBeStatic", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Anonymous", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ArgLengthMismatch", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BadClassSignature", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BadConstPoolTag", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BadConstPoolTagAt", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BadEnclosingClass", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BadModuleInfoName", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BadRequiresFlag", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BadRuntimeInvisibleParamAnnotations", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BadSignature", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BadTypeAnnotationValue", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BaseMembership", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Bound", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Canonical", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CanonicalCantHaveReturnStatement", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CanonicalMustNotContainExplicitConstructorInvocation", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CanonicalMustNotDeclareTypeVariables", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CanonicalWithNameMismatch", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CantResolveModules", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ClassFileWrongClass", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Compact", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ConditionalTargetCantBeVoid", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DiamondAnonymousMethodsImplicitlyOverride", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FatalErrCantClose", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FatalErrNoJavaLang", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureAnnotationsAfterTypeParams", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureCaseNull", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureDefaultMethods", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureDiamond", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureDiamondAndAnonClass", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureIntersectionTypesInCast", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureLambda", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureMethodReferences", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureModules", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureMultipleCaseLabels", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeaturePatternMatchingInstanceof", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeaturePatternSwitch", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeaturePrivateIntfMethods", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureRecords", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureReifiableTypesInstanceof", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureRepeatableAnnotations", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureSealedClasses", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureStaticIntfMethodInvoke", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureStaticIntfMethods", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureSwitchExpressions", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureSwitchRules", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureTextBlocks", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureTypeAnnotations", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureVarInTryWithResources", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FeatureVarSyntaxInImplicitLambda", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FileDoesNotContainModule", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Guard", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IllegalStartOfClassFile", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ImplicitAndExplicitNotAllowed", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IncompatibleArgTypesInLambda", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IncompatibleArgTypesInMref", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "InnerCls", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KindnameAnnotation", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KindnameClass", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KindnameConstructor", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KindnameEnum", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KindnameInstanceInit", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KindnameInterface", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KindnameMethod", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KindnameModule", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KindnamePackage", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KindnameRecord", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KindnameRecordComponent", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KindnameStatic", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KindnameStaticInit", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KindnameTypeVariable", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KindnameTypeVariableBound", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KindnameValue", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KindnameVariable", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Lambda", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Local", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LocalArrayMissingTarget", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LocalCantInferNull", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LocalCantInferVoid", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LocalLambdaMissingTarget", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LocalMissingInit", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LocalMrefMissingTarget", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LocalSelfRef", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LocnModule_path", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LocnModule_source_path", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LocnSystem_modules", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LocnUpgrade_module_path", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MalformedVarargMethod", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MethodMustBePublic", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ModuleInfoDefinitionExpected", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ModuleInfoInvalidSuperClass", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MrefInferAndExplicitParams", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MustNotBeSameClass", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NoArgs", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NonStatic", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ResumeAbort", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SourceUnavailable", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "StatExprExpected", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Static", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "StaticMrefWithTargs", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SwitchExpressionTargetCantBeVoid", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TokenBadSymbol", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TokenCharacter", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TokenDouble", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TokenEndOfInput", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TokenFloat", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TokenIdentifier", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TokenInteger", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TokenLongInteger", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TokenString", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TypeCaptureof1", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TypeMustBeIdenticalToCorrespondingRecordComponentType", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TypeNone", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TypeNull", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TypeReqArrayOrIterable", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TypeReqClass", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TypeReqClassArray", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TypeReqExact", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TypeReqRef", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UnableToAccessFile", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Unbound", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UncheckedAssign", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UncheckedCastToType", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UndeclTypeVar", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UnexpectedConstPoolTagAt", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UnexpectedRetVal", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UnicodeStrNotSupported", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UnnamedModule", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UnnamedPackage", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UserSelectedCompletionFailure", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VarAndExplicitNotAllowed", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VarAndImplicitNotAllowed", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VersionNotAvailable", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WhereDescriptionCaptured", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WrongVersion", "Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ClassIsNotSealed", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ThrowsClauseNotAllowedForCanonicalConstructor", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "TypeParameter", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AccessorReturnTypeDoesntMatch", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AnachronisticModuleInfo", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AnonymousClass", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ApplicableMethodFound", "(ILcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ApplicableMethodFound1", "(ILcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ApplicableMethodFound1", "(ILcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ApplicableMethodFound2", "(ILcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ApplicableMethodFound3", "(ILcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ApplicableMethodFound3", "(ILcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadClassFile", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadClassFileHeader", "(Ljava/nio/file/Path;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadClassFileHeader", "(Ljava/io/File;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadClassFileHeader", "(Ljava/io/File;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadClassFileHeader", "(Ljavax/tools/JavaFileObject;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadClassFileHeader", "(Ljavax/tools/JavaFileObject;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadClassFileHeader", "(Ljava/nio/file/Path;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadConstPoolEntry", "(Ljava/io/File;Ljava/lang/String;I)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadConstPoolEntry", "(Ljavax/tools/JavaFileObject;Ljava/lang/String;I)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadConstPoolEntry", "(Ljava/nio/file/Path;Ljava/lang/String;I)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadConstPoolIndex", "(Ljava/io/File;II)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadConstPoolIndex", "(Ljavax/tools/JavaFileObject;II)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadConstPoolIndex", "(Ljava/nio/file/Path;II)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadConstantRange", "(Ljava/lang/String;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadConstantValue", "(Ljava/lang/String;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadConstantValueType", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadEnclosingMethod", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadInstanceMethodInUnboundLookup", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadIntersectionTargetForFunctionalExpr", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadIntersectionTargetForFunctionalExpr", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadSourceFileHeader", "(Ljava/nio/file/Path;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadSourceFileHeader", "(Ljavax/tools/JavaFileObject;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadSourceFileHeader", "(Ljavax/tools/JavaFileObject;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadSourceFileHeader", "(Ljava/io/File;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadSourceFileHeader", "(Ljava/io/File;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadSourceFileHeader", "(Ljava/nio/file/Path;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadStaticMethodInBoundLookup", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadStaticMethodInUnboundLookup", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CanonicalMustNotHaveStrongerAccess", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CanonicalMustNotHaveStrongerAccess", "(Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantAccessInnerClsConstr", "(Lcom/sun/tools/javac/code/Symbol;Ljava/util/List;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplyDiamond1", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplyDiamond1", "(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplyDiamond1", "(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplyDiamond1", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplyDiamond1", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplyDiamond1", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbols", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantHide", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantImplement", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantOverride", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantResolveArgs", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/lang/Void;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantResolveLocationArgsParams", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantResolveLocationArgsParams", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CapturedType", "(I)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ClashesWith", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CountError", "(I)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CountErrorRecompile", "(II)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CountWarn", "(I)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CountWarnPlural", "(I)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CountWarnRecompile", "(II)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DescriptorThrows", "(Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "Diamond", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DiamondAndExplicitParams", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DiamondInvalidArg", "(Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DiamondInvalidArg", "(Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DiamondInvalidArgs", "(Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DiamondInvalidArgs", "(Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DiamondNonGeneric", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DoesntExtendSealed", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "EqBounds", "(Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ExceptionMessage", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ExplicitParamDoNotConformToBounds", "(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FatalErrCantLocateCtor", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FatalErrCantLocateField", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FatalErrCantLocateMeth", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FeatureNotSupportedInSource", "(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FeatureNotSupportedInSource", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FeatureNotSupportedInSourcePlural", "(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FeatureNotSupportedInSourcePlural", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FileDoesNotContainPackage", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FileDoesntContainClass", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InaccessibleVarargsType", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InapplicableMethod", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InapplicableMethod", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncompatibleAbstractDefault", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncompatibleAbstracts", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncompatibleBounds", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncompatibleDescsInFunctionalIntf", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncompatibleDiffRet", "(Lcom/sun/tools/javac/util/Name;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncompatibleEqBounds", "(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncompatibleRetTypeInLambda", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncompatibleRetTypeInLambda", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncompatibleRetTypeInMref", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncompatibleRetTypeInMref", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncompatibleTypeInConditional", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncompatibleTypeInConditional", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncompatibleTypeInSwitchExpression", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncompatibleTypeInSwitchExpression", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncompatibleUnrelatedDefaults", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncompatibleUpperBounds", "(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InconvertibleTypes", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InferArgLengthMismatch", "(Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InferNoConformingAssignmentExists", "(Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InferNoConformingAssignmentExists", "(Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InferNoConformingInstanceExists", "(Ljava/util/List;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InferVarargsArgumentMismatch", "(Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InferVarargsArgumentMismatch", "(Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InferredDoNotConformToEqBounds", "(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InferredDoNotConformToUpperBounds", "(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IntersectionType", "(I)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidDefaultInterface", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidGenericLambdaTarget", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidMref", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidMref", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidStaticInterface", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IsATypeVariable", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IsDuplicated", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "Location1", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "LowerBounds", "(Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "MethodDescriptorInvalid", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "MissingRetVal", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ModuleNameMismatch", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ModuleNonZeroOpens", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "MustNotBeSupertype", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NoAbstracts", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NoConformingAssignmentExists", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NoConformingAssignmentExists", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NoSuitableFunctionalIntfInst", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NoUniqueMaximalInstanceExists", "(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NoUniqueMinimalInstanceExists", "(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotAFunctionalIntf", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotAFunctionalIntf1", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotAFunctionalIntf1", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotAnIntfComponent", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotAnIntfComponent", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotApplicableMethodFound", "(ILcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotApplicableMethodFound", "(ILcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotDefAccessClassIntfCantAccess", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotDefAccessDoesNotRead", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotDefAccessDoesNotReadFromUnnamed", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotDefAccessDoesNotReadUnnamed", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotDefAccessNotExported", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotDefAccessNotExportedFromUnnamed", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotDefAccessNotExportedToModule", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotDefAccessPackageCantAccess", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotDefAccessPackageCantAccess", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotDefPublicCantAccess", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PackageNotVisible", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PackageNotVisible", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PartialInstSig", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProbFoundReq", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProbFoundReq", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RedundantSupertype", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RedundantSupertype", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RefAmbiguous", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ReportAccess", "(Lcom/sun/tools/javac/code/Symbol;Ljava/util/Set;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SyntheticNameConflict", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "TryNotApplicableToType", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "TryNotApplicableToType", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "TypeCaptureof", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "TypeVar", "(Lcom/sun/tools/javac/util/Name;I)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UncheckedClashWith", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UncheckedImplement", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UncheckedOverride", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UpperBounds", "(Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VarargsArgumentMismatch", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VarargsArgumentMismatch", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VarargsClashWith", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VarargsImplement", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VarargsOverride", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VarargsTrustmeOnNonVarargsAccessor", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VarargsTrustmeOnNonVarargsMeth", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VarargsTrustmeOnReifiableVarargs", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VarargsTrustmeOnVirtualVarargs", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseCheckingAttribution", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseClasspath", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseLoading", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseParsingDone", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseParsingStarted", "(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseParsingStarted", "(Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseParsingStarted", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseSourcepath", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseTotal", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseWroteFile", "(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseWroteFile", "(Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseWroteFile", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "WhereCaptured", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "WhereCaptured1", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Ljava/lang/Void;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "WhereDescriptionCaptured1", "(Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "WhereDescriptionIntersection", "(Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "WhereDescriptionIntersection1", "(Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "WhereDescriptionTypevar", "(Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "WhereDescriptionTypevar1", "(Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "WhereFreshTypevar", "(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "WhereIntersection", "(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "WhereTypevar", "(Lcom/sun/tools/javac/code/Type;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "WhereTypevar1", "(Lcom/sun/tools/javac/code/Type;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "WrongNumberTypeArgs", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XPrintProcessorInfo", "(Ljava/lang/String;Ljava/lang/String;Z)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "XPrintRounds", "(ILjava/lang/String;Ljava/util/Set;Z)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotDefAccessClassIntfCantAccessReason", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotDefAccessClassIntfCantAccessReason", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "Descriptor", "(Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VarargsTrustmeOnVirtualVarargsFinalOnly", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ClassFileNotFound", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantResolveLocationArgs", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/lang/Void;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantResolveLocationArgs", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/lang/Void;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InferredDoNotConformToLowerBounds", "(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "Location", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "Location", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Type;Ljava/lang/Void;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotDefAccessNotExportedToModuleFromUnnamed", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IllegalSignature", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CountErrorPlural", "(I)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverriddenDefault", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PossibleLossOfPrecision", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment AccessorMethodCantThrowException_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment AccessorMethodMustNotBeGeneric_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment AccessorMethodMustNotBeStatic_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment Anonymous_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ArgLengthMismatch_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadClassSignature_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadConstPoolTag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadConstPoolTagAt_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadEnclosingClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadModuleInfoName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadRequiresFlag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadRuntimeInvisibleParamAnnotations_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadSignature_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadTypeAnnotationValue_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BaseMembership_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment Bound_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment Canonical_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CanonicalCantHaveReturnStatement_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CanonicalMustNotContainExplicitConstructorInvocation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CanonicalMustNotDeclareTypeVariables_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CanonicalWithNameMismatch_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantResolveModules_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ClassFileWrongClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment Compact_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ConditionalTargetCantBeVoid_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment DiamondAnonymousMethodsImplicitlyOverride_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FatalErrCantClose_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FatalErrNoJavaLang_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureAnnotationsAfterTypeParams_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureCaseNull_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureDefaultMethods_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureDiamond_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureDiamondAndAnonClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureIntersectionTypesInCast_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureLambda_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureMethodReferences_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureModules_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureMultipleCaseLabels_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeaturePatternMatchingInstanceof_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeaturePatternSwitch_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeaturePrivateIntfMethods_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureRecords_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureReifiableTypesInstanceof_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureRepeatableAnnotations_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureSealedClasses_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureStaticIntfMethodInvoke_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureStaticIntfMethods_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureSwitchExpressions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureSwitchRules_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureTextBlocks_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureTypeAnnotations_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureVarInTryWithResources_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureVarSyntaxInImplicitLambda_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FileDoesNotContainModule_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment Guard_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IllegalStartOfClassFile_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[55]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[55], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ImplicitAndExplicitNotAllowed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[56]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[56], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IncompatibleArgTypesInLambda_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IncompatibleArgTypesInMref_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment InnerCls_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment KindnameAnnotation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment KindnameClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[61]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[61], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment KindnameConstructor_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[62]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[62], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment KindnameEnum_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[63]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[63], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment KindnameInstanceInit_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment KindnameInterface_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment KindnameMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment KindnameModule_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment KindnamePackage_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[68]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[68], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment KindnameRecord_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[69]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[69], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment KindnameRecordComponent_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment KindnameStatic_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[71]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[71], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment KindnameStaticInit_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[72]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[72], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment KindnameTypeVariable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[73]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[73], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment KindnameTypeVariableBound_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[74]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[74], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment KindnameValue_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[75]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[75], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment KindnameVariable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[76]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[76], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment Lambda_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[77]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[77], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment Local_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[78]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[78], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment LocalArrayMissingTarget_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[79]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[79], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment LocalCantInferNull_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[80]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[80], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment LocalCantInferVoid_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[81]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[81], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment LocalLambdaMissingTarget_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[82]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[82], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment LocalMissingInit_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[83]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[83], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment LocalMrefMissingTarget_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[84]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[84], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment LocalSelfRef_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[85]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[85], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment LocnModule_path_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[86]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[86], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment LocnModule_source_path_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[87]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[87], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment LocnSystem_modules_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[88]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[88], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment LocnUpgrade_module_path_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[89]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[89], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment MalformedVarargMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[90]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[90], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment MethodMustBePublic_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[91]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[91], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ModuleInfoDefinitionExpected_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[92]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[92], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ModuleInfoInvalidSuperClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[93]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[93], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment MrefInferAndExplicitParams_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[94]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[94], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment MustNotBeSameClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[95]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[95], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NoArgs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[96]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[96], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NonStatic_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[97]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[97], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ResumeAbort_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[98]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[98], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment SourceUnavailable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[99]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[99], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment StatExprExpected_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[100]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[100], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment Static_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[101]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[101], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment StaticMrefWithTargs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[102]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[102], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment SwitchExpressionTargetCantBeVoid_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[103]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[103], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TokenBadSymbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[104]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[104], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TokenCharacter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[105]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[105], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TokenDouble_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[106]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[106], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TokenEndOfInput_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[107]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[107], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TokenFloat_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[108]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[108], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TokenIdentifier_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[109]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[109], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TokenInteger_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[110]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[110], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TokenLongInteger_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[111]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[111], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TokenString_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[112]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[112], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TypeCaptureof1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[113]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[113], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TypeMustBeIdenticalToCorrespondingRecordComponentType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[114]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[114], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TypeNone_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[115]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[115], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TypeNull_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[116]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[116], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TypeReqArrayOrIterable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[117]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[117], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TypeReqClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[118]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[118], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TypeReqClassArray_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[119]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[119], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TypeReqExact_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[120]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[120], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TypeReqRef_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[121]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[121], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment UnableToAccessFile_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[122]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[122], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment Unbound_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[123]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[123], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment UncheckedAssign_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[124]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[124], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment UncheckedCastToType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[125]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[125], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment UndeclTypeVar_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[126]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[126], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment UnexpectedConstPoolTagAt_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[127]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[127], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment UnexpectedRetVal_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[128]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[128], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment UnicodeStrNotSupported_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[129]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[129], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment UnnamedModule_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[130]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[130], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment UnnamedPackage_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[131]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[131], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment UserSelectedCompletionFailure_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[132]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[132], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VarAndExplicitNotAllowed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[133]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[133], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VarAndImplicitNotAllowed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[134]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[134], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VersionNotAvailable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[135]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[135], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment WhereDescriptionCaptured_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[136]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[136], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment WrongVersion_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[137]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[137], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Fragments(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Fragments() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/resources/CompilerProperties$Fragments;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ClassIsNotSealed(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ThrowsClauseNotAllowedForCanonicalConstructor(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TypeParameter(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment AccessorReturnTypeDoesntMatch(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment AnachronisticModuleInfo(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment AnonymousClass(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(ILcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ApplicableMethodFound(int arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.java.lang.Void arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(ILcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ApplicableMethodFound1(int arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(ILcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ApplicableMethodFound1(int arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(ILcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ApplicableMethodFound2(int arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(ILcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ApplicableMethodFound3(int arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(ILcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ApplicableMethodFound3(int arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadClassFile(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadClassFileHeader(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadClassFileHeader(Dova.JDK.java.io.File arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadClassFileHeader(Dova.JDK.java.io.File arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadClassFileHeader(Dova.JDK.javax.tools.JavaFileObject arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadClassFileHeader(Dova.JDK.javax.tools.JavaFileObject arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadClassFileHeader(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;Ljava/lang/String;I)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadConstPoolEntry(Dova.JDK.java.io.File arg0, Dova.JDK.java.lang.String arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;Ljava/lang/String;I)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadConstPoolEntry(Dova.JDK.javax.tools.JavaFileObject arg0, Dova.JDK.java.lang.String arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/String;I)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadConstPoolEntry(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.String arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;II)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadConstPoolIndex(Dova.JDK.java.io.File arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;II)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadConstPoolIndex(Dova.JDK.javax.tools.JavaFileObject arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;II)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadConstPoolIndex(Dova.JDK.java.nio.file.Path arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadConstantRange(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadConstantValue(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadConstantValueType(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadEnclosingMethod(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadInstanceMethodInUnboundLookup(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadIntersectionTargetForFunctionalExpr(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadIntersectionTargetForFunctionalExpr(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadSourceFileHeader(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadSourceFileHeader(Dova.JDK.javax.tools.JavaFileObject arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadSourceFileHeader(Dova.JDK.javax.tools.JavaFileObject arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadSourceFileHeader(Dova.JDK.java.io.File arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadSourceFileHeader(Dova.JDK.java.io.File arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadSourceFileHeader(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadStaticMethodInBoundLookup(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment BadStaticMethodInUnboundLookup(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CanonicalMustNotHaveStrongerAccess(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CanonicalMustNotHaveStrongerAccess(Dova.JDK.java.util.Set arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[41], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Ljava/util/List;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantAccessInnerClsConstr(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.java.util.List arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplyDiamond1(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[43], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplyDiamond1(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[44], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplyDiamond1(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[45], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplyDiamond1(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[46], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplyDiamond1(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[47], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplyDiamond1(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[48], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[49], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[50], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[51], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[52], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[53], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[54], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[55], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.util.List arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[56], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.util.List arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[57], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[58], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.util.List arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[59], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.util.List arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[60], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[61], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[62], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[63], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[64], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[65], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[66], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantApplySymbols(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.util.List arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[67], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantHide(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.code.Symbol arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[68], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantImplement(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.code.Symbol arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[69], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantOverride(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.code.Symbol arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[70], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/lang/Void;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantResolveArgs(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.lang.Void arg2, Dova.JDK.java.util.List arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[71], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantResolveLocationArgsParams(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg4)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[72], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantResolveLocationArgsParams(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg4)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[73], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(I)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CapturedType(int arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[74], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ClashesWith(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.code.Symbol arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[75], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(I)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CountError(int arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[76], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(II)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CountErrorRecompile(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[77], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(I)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CountWarn(int arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[78], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(I)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CountWarnPlural(int arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[79], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(II)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CountWarnRecompile(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[80], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment DescriptorThrows(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.java.util.List arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.java.util.List arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[81], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment Diamond(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[82], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment DiamondAndExplicitParams(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[83], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment DiamondInvalidArg(Dova.JDK.java.util.List arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[84], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment DiamondInvalidArg(Dova.JDK.java.util.List arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[85], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment DiamondInvalidArgs(Dova.JDK.java.util.List arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[86], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment DiamondInvalidArgs(Dova.JDK.java.util.List arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[87], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment DiamondNonGeneric(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[88], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment DoesntExtendSealed(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[89], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment EqBounds(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[90], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ExceptionMessage(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[91], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ExplicitParamDoNotConformToBounds(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[92], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FatalErrCantLocateCtor(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[93], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FatalErrCantLocateField(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[94], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FatalErrCantLocateMeth(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[95], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureNotSupportedInSource(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[96], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureNotSupportedInSource(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[97], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureNotSupportedInSourcePlural(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[98], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FeatureNotSupportedInSourcePlural(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[99], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FileDoesNotContainPackage(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[100], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment FileDoesntContainClass(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[101], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment InaccessibleVarargsType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[102], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment InapplicableMethod(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[103], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment InapplicableMethod(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[104], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IncompatibleAbstractDefault(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.Name arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.code.Symbol arg4, Dova.JDK.com.sun.tools.javac.code.Symbol arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[105], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IncompatibleAbstracts(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[106], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IncompatibleBounds(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[107], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IncompatibleDescsInFunctionalIntf(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[108], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IncompatibleDiffRet(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[109], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IncompatibleEqBounds(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[110], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IncompatibleRetTypeInLambda(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[111], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IncompatibleRetTypeInLambda(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[112], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IncompatibleRetTypeInMref(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[113], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IncompatibleRetTypeInMref(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[114], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IncompatibleTypeInConditional(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[115], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IncompatibleTypeInConditional(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[116], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IncompatibleTypeInSwitchExpression(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[117], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IncompatibleTypeInSwitchExpression(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[118], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IncompatibleUnrelatedDefaults(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.Name arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.code.Symbol arg4, Dova.JDK.com.sun.tools.javac.code.Symbol arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[119], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IncompatibleUpperBounds(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[120], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment InconvertibleTypes(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[121], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment InferArgLengthMismatch(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[122], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment InferNoConformingAssignmentExists(Dova.JDK.java.util.List arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[123], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment InferNoConformingAssignmentExists(Dova.JDK.java.util.List arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[124], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment InferNoConformingInstanceExists(Dova.JDK.java.util.List arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[125], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment InferVarargsArgumentMismatch(Dova.JDK.java.util.List arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[126], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment InferVarargsArgumentMismatch(Dova.JDK.java.util.List arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[127], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment InferredDoNotConformToEqBounds(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[128], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment InferredDoNotConformToUpperBounds(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[129], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(I)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IntersectionType(int arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[130], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment InvalidDefaultInterface(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[131], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment InvalidGenericLambdaTarget(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[132], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment InvalidMref(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[133], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment InvalidMref(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[134], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment InvalidStaticInterface(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[135], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IsATypeVariable(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[136], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IsDuplicated(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[137], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment Location1(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[138], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment LowerBounds(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[139], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment MethodDescriptorInvalid(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[140], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment MissingRetVal(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[141], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ModuleNameMismatch(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[142], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ModuleNonZeroOpens(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[143], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment MustNotBeSupertype(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[144], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NoAbstracts(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[145], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NoConformingAssignmentExists(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[146], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NoConformingAssignmentExists(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[147], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NoSuitableFunctionalIntfInst(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[148], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NoUniqueMaximalInstanceExists(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[149], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NoUniqueMinimalInstanceExists(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[150], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NotAFunctionalIntf(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[151], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NotAFunctionalIntf1(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[152], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NotAFunctionalIntf1(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[153], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NotAnIntfComponent(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[154], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NotAnIntfComponent(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[155], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(ILcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NotApplicableMethodFound(int arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[156], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(ILcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NotApplicableMethodFound(int arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[157], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NotDefAccessClassIntfCantAccess(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[158], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NotDefAccessDoesNotRead(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[159], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NotDefAccessDoesNotReadFromUnnamed(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[160], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NotDefAccessDoesNotReadUnnamed(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[161], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NotDefAccessNotExported(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[162], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NotDefAccessNotExportedFromUnnamed(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[163], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NotDefAccessNotExportedToModule(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[164], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NotDefAccessPackageCantAccess(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[165], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NotDefAccessPackageCantAccess(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[166], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NotDefPublicCantAccess(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[167], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment PackageNotVisible(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[168], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment PackageNotVisible(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[169], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment PartialInstSig(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[170], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ProbFoundReq(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[171], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ProbFoundReq(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[172], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment RedundantSupertype(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[173], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment RedundantSupertype(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[174], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment RefAmbiguous(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.code.Symbol arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Symbol arg5, Dova.JDK.com.sun.tools.javac.code.Symbol arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[175], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Ljava/util/Set;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ReportAccess(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.java.util.Set arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[176], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment SyntheticNameConflict(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[177], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TryNotApplicableToType(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[178], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TryNotApplicableToType(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[179], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TypeCaptureof(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[180], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;I)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment TypeVar(Dova.JDK.com.sun.tools.javac.util.Name arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[181], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment UncheckedClashWith(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.code.Symbol arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[182], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment UncheckedImplement(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.code.Symbol arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[183], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment UncheckedOverride(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.code.Symbol arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[184], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment UpperBounds(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[185], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VarargsArgumentMismatch(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[186], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VarargsArgumentMismatch(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[187], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VarargsClashWith(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.code.Symbol arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[188], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VarargsImplement(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.code.Symbol arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[189], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VarargsOverride(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.code.Symbol arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[190], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VarargsTrustmeOnNonVarargsAccessor(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[191], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VarargsTrustmeOnNonVarargsMeth(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[192], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VarargsTrustmeOnReifiableVarargs(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[193], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VarargsTrustmeOnVirtualVarargs(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[194], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VerboseCheckingAttribution(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[195], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VerboseClasspath(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[196], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VerboseLoading(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[197], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VerboseParsingDone(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[198], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VerboseParsingStarted(Dova.JDK.javax.tools.JavaFileObject arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[199], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VerboseParsingStarted(Dova.JDK.java.io.File arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[200], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VerboseParsingStarted(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[201], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VerboseSourcepath(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[202], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VerboseTotal(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[203], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VerboseWroteFile(Dova.JDK.javax.tools.JavaFileObject arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[204], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VerboseWroteFile(Dova.JDK.java.io.File arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[205], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VerboseWroteFile(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[206], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment WhereCaptured(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.com.sun.tools.javac.code.Type arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[207], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Ljava/lang/Void;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment WhereCaptured1(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.java.lang.Void arg2, Dova.JDK.com.sun.tools.javac.code.Type arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[208], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment WhereDescriptionCaptured1(Dova.JDK.java.util.Set arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[209], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment WhereDescriptionIntersection(Dova.JDK.java.util.Set arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[210], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment WhereDescriptionIntersection1(Dova.JDK.java.util.Set arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[211], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment WhereDescriptionTypevar(Dova.JDK.java.util.Set arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[212], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment WhereDescriptionTypevar1(Dova.JDK.java.util.Set arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[213], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment WhereFreshTypevar(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[214], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment WhereIntersection(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[215], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment WhereTypevar(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.util.List arg1, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg2, Dova.JDK.com.sun.tools.javac.code.Symbol arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[216], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment WhereTypevar1(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.util.List arg1, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg2, Dova.JDK.com.sun.tools.javac.code.Symbol arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[217], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment WrongNumberTypeArgs(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[218], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Z)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment XPrintProcessorInfo(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, bool arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[219], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(ILjava/lang/String;Ljava/util/Set;Z)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment XPrintRounds(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Set arg2, bool arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[220], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NotDefAccessClassIntfCantAccessReason(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[221], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NotDefAccessClassIntfCantAccessReason(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[222], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment Descriptor(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.java.util.List arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.java.util.List arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[223], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment VarargsTrustmeOnVirtualVarargsFinalOnly(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[224], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment ClassFileNotFound(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[225], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/lang/Void;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantResolveLocationArgs(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.lang.Void arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg4)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[226], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/lang/Void;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CantResolveLocationArgs(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.lang.Void arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg4)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[227], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment InferredDoNotConformToLowerBounds(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[228], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment Location(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.java.lang.Void arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[229], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Type;Ljava/lang/Void;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment Location(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.java.lang.Void arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[230], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment NotDefAccessNotExportedToModuleFromUnnamed(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[231], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment IllegalSignature(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[232], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(I)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment CountErrorPlural(int arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[233], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment OverriddenDefault(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[234], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment PossibleLossOfPrecision(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[235], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/resources/CompilerProperties$Notes;", "public static")]
	public partial class Notes
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Notes()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/resources/CompilerProperties$Notes;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CompressedDiags", "Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DeprecatedPlural", "Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DeprecatedPluralAdditional", "Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DeprecatedRecompile", "Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Note", "Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PreviewRecompile", "Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RemovalPlural", "Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RemovalPluralAdditional", "Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RemovalRecompile", "Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UncheckedPlural", "Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UncheckedPluralAdditional", "Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UncheckedRecompile", "Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcMessager", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PreviewFilename", "(Ljavax/tools/JavaFileObject;Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PreviewFilename", "(Ljava/nio/file/Path;Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PreviewFilename", "(Ljava/io/File;Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PreviewFilenameAdditional", "(Ljava/nio/file/Path;Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PreviewFilenameAdditional", "(Ljava/io/File;Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PreviewFilenameAdditional", "(Ljavax/tools/JavaFileObject;Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PreviewPlural", "(Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PreviewPluralAdditional", "(Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RemovalFilename", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RemovalFilename", "(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RemovalFilename", "(Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RemovalFilenameAdditional", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RemovalFilenameAdditional", "(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RemovalFilenameAdditional", "(Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DeprecatedFilename", "(Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DeprecatedFilename", "(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DeprecatedFilename", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DeprecatedFilenameAdditional", "(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DeprecatedFilenameAdditional", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DeprecatedFilenameAdditional", "(Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "LambdaStat", "(ZLcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "MethodRefSearchResultsMulti", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/lang/String;I)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "MrefStat", "(ZLjava/lang/Void;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "MrefStat1", "(ZLcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "MultipleElements", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DeferredMethodInst", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UncheckedFilename", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UncheckedFilename", "(Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UncheckedFilename", "(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UncheckedFilenameAdditional", "(Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UncheckedFilenameAdditional", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UncheckedFilenameAdditional", "(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseL2mDeduplicate", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseResolveMulti", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;ILjava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseResolveMulti", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;ILjava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseResolveMulti", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;ILjava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseResolveMulti", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;ILjava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseResolveMulti", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;ILjava/lang/String;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseResolveMulti", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;ILjava/lang/String;Ljava/util/List;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseResolveMulti", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;ILjava/lang/String;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseResolveMulti", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;ILjava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseResolveMulti", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;ILjava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseResolveMulti1", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;Ljava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseResolveMulti1", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;Ljava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseResolveMulti1", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;Ljava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseResolveMulti1", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;Ljava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseResolveMulti1", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;Ljava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseResolveMulti1", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;Ljava/lang/String;Ljava/util/List;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseResolveMulti1", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;Ljava/lang/String;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseResolveMulti1", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;Ljava/lang/String;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VerboseResolveMulti1", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;Ljava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note CompressedDiags_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note DeprecatedPlural_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note DeprecatedPluralAdditional_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note DeprecatedRecompile_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note Note_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note PreviewRecompile_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note RemovalPlural_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note RemovalPluralAdditional_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note RemovalRecompile_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note UncheckedPlural_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note UncheckedPluralAdditional_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note UncheckedRecompile_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Notes(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Notes() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/resources/CompilerProperties$Notes;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note ProcMessager(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note PreviewFilename(Dova.JDK.javax.tools.JavaFileObject arg0, Dova.JDK.com.sun.tools.javac.code.Source arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note PreviewFilename(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.com.sun.tools.javac.code.Source arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note PreviewFilename(Dova.JDK.java.io.File arg0, Dova.JDK.com.sun.tools.javac.code.Source arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note PreviewFilenameAdditional(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.com.sun.tools.javac.code.Source arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note PreviewFilenameAdditional(Dova.JDK.java.io.File arg0, Dova.JDK.com.sun.tools.javac.code.Source arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note PreviewFilenameAdditional(Dova.JDK.javax.tools.JavaFileObject arg0, Dova.JDK.com.sun.tools.javac.code.Source arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note PreviewPlural(Dova.JDK.com.sun.tools.javac.code.Source arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note PreviewPluralAdditional(Dova.JDK.com.sun.tools.javac.code.Source arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note RemovalFilename(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note RemovalFilename(Dova.JDK.javax.tools.JavaFileObject arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note RemovalFilename(Dova.JDK.java.io.File arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note RemovalFilenameAdditional(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note RemovalFilenameAdditional(Dova.JDK.javax.tools.JavaFileObject arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note RemovalFilenameAdditional(Dova.JDK.java.io.File arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note DeprecatedFilename(Dova.JDK.java.io.File arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note DeprecatedFilename(Dova.JDK.javax.tools.JavaFileObject arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note DeprecatedFilename(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note DeprecatedFilenameAdditional(Dova.JDK.javax.tools.JavaFileObject arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note DeprecatedFilenameAdditional(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note DeprecatedFilenameAdditional(Dova.JDK.java.io.File arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(ZLcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note LambdaStat(bool arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/lang/String;I)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note MethodRefSearchResultsMulti(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0, Dova.JDK.java.lang.String arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(ZLjava/lang/Void;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note MrefStat(bool arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(ZLcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note MrefStat1(bool arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note MultipleElements(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note DeferredMethodInst(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note UncheckedFilename(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note UncheckedFilename(Dova.JDK.java.io.File arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note UncheckedFilename(Dova.JDK.javax.tools.JavaFileObject arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note UncheckedFilenameAdditional(Dova.JDK.java.io.File arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note UncheckedFilenameAdditional(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note UncheckedFilenameAdditional(Dova.JDK.javax.tools.JavaFileObject arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note VerboseL2mDeduplicate(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;ILjava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note VerboseResolveMulti(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg4, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;ILjava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note VerboseResolveMulti(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg4, Dova.JDK.java.util.List arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;ILjava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note VerboseResolveMulti(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg4, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;ILjava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note VerboseResolveMulti(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg4, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;ILjava/lang/String;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note VerboseResolveMulti(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.util.List arg4, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;ILjava/lang/String;Ljava/util/List;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note VerboseResolveMulti(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.util.List arg4, Dova.JDK.java.util.List arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;ILjava/lang/String;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note VerboseResolveMulti(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.util.List arg4, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;ILjava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note VerboseResolveMulti(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg4, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[41], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;ILjava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note VerboseResolveMulti(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg4, Dova.JDK.java.util.List arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;Ljava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note VerboseResolveMulti1(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.java.lang.Void arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg4, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[43], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;Ljava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note VerboseResolveMulti1(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.java.lang.Void arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg4, Dova.JDK.java.util.List arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[44], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;Ljava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note VerboseResolveMulti1(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.java.lang.Void arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg4, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[45], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;Ljava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note VerboseResolveMulti1(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.java.lang.Void arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg4, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[46], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;Ljava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note VerboseResolveMulti1(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.java.lang.Void arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg4, Dova.JDK.java.util.List arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[47], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;Ljava/lang/String;Ljava/util/List;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note VerboseResolveMulti1(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.java.lang.Void arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.util.List arg4, Dova.JDK.java.util.List arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[48], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;Ljava/lang/String;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note VerboseResolveMulti1(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.java.lang.Void arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.util.List arg4, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[49], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;Ljava/lang/String;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note VerboseResolveMulti1(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.java.lang.Void arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.util.List arg4, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[50], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Void;Ljava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Note;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note VerboseResolveMulti1(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.java.lang.Void arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg4, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[51], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Note>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/resources/CompilerProperties$Warnings;", "public static")]
	public partial class Warnings
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Warnings()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/resources/CompilerProperties$Warnings;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OSFArraySPF", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SPFNullInit", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AddopensIgnored", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AttemptToSynchronizeOnInstanceOfValueBasedClass", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DefaultIneffective", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DiamondRedundantArgs", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DivZero", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DoclintNotAvailable", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EmptyIf", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ExternalizableMissingPublicNoArgCtor", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FinallyCannotComplete", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IllegalCharForEncoding", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ImproperSPF", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "InconsistentWhiteSpaceIndentation", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IneffectualSerialFieldExternalizable", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IneffectualSerialFieldInterface", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IneffectualSerialFieldRecord", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "InvalidYield", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LocalRedundantType", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MethodRedundantTypeargs", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MissingDeprecatedAnnotation", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NonPrivateMethodWeakerAccess", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NonSerializableInstanceField", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OptionObsoleteSuppression", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PossibleFallThroughIntoCase", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PotentialLambdaFound", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ProcProcOnlyRequestedNoProcs", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ProcUseImplicit", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ProcUseProcOrImplicit", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RequiresAutomatic", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RequiresTransitiveAutomatic", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Strictfp", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TrailingWhiteSpaceWillBeRemoved", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TryExplicitCloseCall", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UncheckedAssign", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UncheckedCastToType", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UnderscoreAsIdentifier", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Warning", "Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RestrictedTypeNotAllowed", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RestrictedTypeNotAllowedPreview", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProbFoundReq", "(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProbFoundReq", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidPath", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IllegalRefToRestrictedType", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcMessager", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PkgInfoAlreadySeen", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "TryResourceThrowsInterruptedExc", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "StaticNotQualifiedByType", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UncheckedAssignToVar", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SelfRef", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ForwardRef", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UncheckedCallMbrOfRawType", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UncheckedMethInvocationApplied", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/lang/Object;Ljava/lang/Object;Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AccessToMemberFromSerializableElement", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AccessToMemberFromSerializableLambda", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AnnotationMethodNotFound", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AnnotationMethodNotFoundReason", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AnnotationMethodNotFoundReason", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AuxiliaryClassAccessedFromOutsideOfItsSourceFile", "(Lcom/sun/tools/javac/code/Symbol;Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AuxiliaryClassAccessedFromOutsideOfItsSourceFile", "(Lcom/sun/tools/javac/code/Symbol;Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AuxiliaryClassAccessedFromOutsideOfItsSourceFile", "(Lcom/sun/tools/javac/code/Symbol;Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AuxiliaryClassAccessedFromOutsideOfItsSourceFile", "(Lcom/sun/tools/javac/code/Type;Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AuxiliaryClassAccessedFromOutsideOfItsSourceFile", "(Lcom/sun/tools/javac/code/Type;Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AuxiliaryClassAccessedFromOutsideOfItsSourceFile", "(Lcom/sun/tools/javac/code/Type;Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadNameForOption", "(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BigMajorVersion", "(Ljava/nio/file/Path;II)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BigMajorVersion", "(Ljava/io/File;II)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BigMajorVersion", "(Ljavax/tools/JavaFileObject;II)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ConstantSVUID", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DeclaredUsingPreview", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DeprecatedAnnotationHasNoEffect", "(Lcom/sun/tools/javac/code/Kinds$KindName;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DirPathElementNotDirectory", "(Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DirPathElementNotDirectory", "(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DirPathElementNotDirectory", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DirPathElementNotFound", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FileFromFuture", "(Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FileFromFuture", "(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FileFromFuture", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FutureAttr", "(Lcom/sun/tools/javac/util/Name;IIII)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "HasBeenDeprecated", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "HasBeenDeprecatedForRemoval", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "HasBeenDeprecatedForRemovalModule", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "HasBeenDeprecatedModule", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ImproperSVUID", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncubatingModules", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IneffectualSerialFieldEnum", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IneffectualSerialMethodEnum", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IneffectualSerialMethodExternalizable", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IneffectualSerialMethodRecord", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InexactNonVarargsCall", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidArchiveFile", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IsPreview", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IsPreviewReflective", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "LeaksNotAccessible", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "LeaksNotAccessibleNotRequiredTransitive", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "LeaksNotAccessibleUnexported", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "LeaksNotAccessibleUnexportedQualified", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "LintOption", "(Lcom/sun/tools/javac/main/Option;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "LocnUnknownFileOnModulePath", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "LongSVUID", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "MissingExplicitCtor", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "MissingSVUID", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ModuleForOptionNotFound", "(Lcom/sun/tools/javac/main/Option;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ModuleNotFound", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NonSerializableInstanceFieldArray", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OptionObsoleteSource", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OptionObsoleteTarget", "(Lcom/sun/tools/javac/jvm/Target;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OptionParametersUnsupported", "(Lcom/sun/tools/javac/jvm/Target;Lcom/sun/tools/javac/jvm/Target;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OutdirIsInExplodedModule", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideBridge", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideBridge", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideEqualsButNotHashcode", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideUncheckedRet", "(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideUncheckedRet", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideUncheckedThrown", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideUncheckedThrown", "(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideVarargsExtra", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideVarargsExtra", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideVarargsMissing", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideVarargsMissing", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PackageEmptyOrNotFound", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PathElementNotFound", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PoorChoiceForModuleName", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PositionOverflow", "(I)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PotentiallyAmbiguousOverload", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PreviewFeatureUse", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PreviewFeatureUse", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PreviewFeatureUseClassfile", "(Ljavax/tools/JavaFileObject;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PreviewFeatureUsePlural", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PreviewFeatureUsePlural", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcAnnotationsWithoutProcessors", "(Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcDuplicateOptionName", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcDuplicateSupportedAnnotation", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcFileCreateLastRound", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcFileReopening", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcIllegalFileName", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcMalformedSupportedString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcPackageDoesNotExist", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcProcessorIncompatibleSourceVersion", "(Ljavax/lang/model/SourceVersion;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcRedundantTypesWithWildcard", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcSuspiciousClassName", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcTypeAlreadyExists", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcTypeRecreate", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcUnclosedTypeFiles", "(Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcUnmatchedProcessorOptions", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProfileTargetConflict", "(Lcom/sun/tools/javac/jvm/Profile;Lcom/sun/tools/javac/jvm/Target;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RawClassUse", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RedundantCast", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SerialConcreteInstanceMethod", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SerialMethodNoArgs", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SerialMethodNotPrivate", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SerialMethodOneArg", "(Lcom/sun/tools/javac/util/Name;I)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SerialMethodParameterType", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SerialMethodStatic", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SerialMethodUnexpectedException", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SerialMethodUnexpectedReturnType", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SerializableMissingAccessNoArgCtor", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ServiceProvidedButNotExportedOrUsed", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SourceNoBootclasspath", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SourceNoSystemModulesPath", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SourceTargetConflict", "(Ljava/lang/String;Lcom/sun/tools/javac/jvm/Target;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SunProprietary", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "TargetDefaultSourceConflict", "(Ljava/lang/String;Lcom/sun/tools/javac/jvm/Target;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "TryResourceNotReferenced", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UncheckedGenericArrayCreation", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UncheckedVarargsNonReifiableType", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UnexpectedArchiveFile", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UnknownEnumConstant", "(Ljavax/tools/JavaFileObject;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UnknownEnumConstantReason", "(Ljavax/tools/JavaFileObject;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UnknownEnumConstantReason", "(Ljavax/tools/JavaFileObject;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UnreachableCatch", "(Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UnreachableCatch1", "(Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VarargsRedundantTrustmeAnno", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VarargsRedundantTrustmeAnno", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VarargsUnsafeUseVarargsParam", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning OSFArraySPF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning SPFNullInit_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning AddopensIgnored_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning AttemptToSynchronizeOnInstanceOfValueBasedClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning DefaultIneffective_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning DiamondRedundantArgs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning DivZero_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning DoclintNotAvailable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning EmptyIf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ExternalizableMissingPublicNoArgCtor_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning FinallyCannotComplete_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning IllegalCharForEncoding_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ImproperSPF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning InconsistentWhiteSpaceIndentation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning IneffectualSerialFieldExternalizable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning IneffectualSerialFieldInterface_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning IneffectualSerialFieldRecord_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning InvalidYield_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning LocalRedundantType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning MethodRedundantTypeargs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning MissingDeprecatedAnnotation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning NonPrivateMethodWeakerAccess_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning NonSerializableInstanceField_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning OptionObsoleteSuppression_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning PossibleFallThroughIntoCase_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning PotentialLambdaFound_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProcProcOnlyRequestedNoProcs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProcUseImplicit_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProcUseProcOrImplicit_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning RequiresAutomatic_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning RequiresTransitiveAutomatic_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning Strictfp_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning TrailingWhiteSpaceWillBeRemoved_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning TryExplicitCloseCall_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning UncheckedAssign_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning UncheckedCastToType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning UnderscoreAsIdentifier_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning Warning_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Warnings(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Warnings() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/resources/CompilerProperties$Warnings;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning RestrictedTypeNotAllowed(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Source arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning RestrictedTypeNotAllowedPreview(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Source arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProbFoundReq(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProbFoundReq(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning InvalidPath(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning IllegalRefToRestrictedType(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProcMessager(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning PkgInfoAlreadySeen(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning TryResourceThrowsInterruptedExc(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning StaticNotQualifiedByType(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning UncheckedAssignToVar(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning SelfRef(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ForwardRef(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning UncheckedCallMbrOfRawType(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/lang/Object;Ljava/lang/Object;Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning UncheckedMethInvocationApplied(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg4, Dova.JDK.com.sun.tools.javac.code.Symbol arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning AccessToMemberFromSerializableElement(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning AccessToMemberFromSerializableLambda(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning AnnotationMethodNotFound(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning AnnotationMethodNotFoundReason(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning AnnotationMethodNotFoundReason(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning AuxiliaryClassAccessedFromOutsideOfItsSourceFile(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.java.nio.file.Path arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning AuxiliaryClassAccessedFromOutsideOfItsSourceFile(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.java.io.File arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning AuxiliaryClassAccessedFromOutsideOfItsSourceFile(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.javax.tools.JavaFileObject arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning AuxiliaryClassAccessedFromOutsideOfItsSourceFile(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.nio.file.Path arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning AuxiliaryClassAccessedFromOutsideOfItsSourceFile(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.javax.tools.JavaFileObject arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning AuxiliaryClassAccessedFromOutsideOfItsSourceFile(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.io.File arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning BadNameForOption(Dova.JDK.com.sun.tools.javac.main.Option arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;II)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning BigMajorVersion(Dova.JDK.java.nio.file.Path arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;II)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning BigMajorVersion(Dova.JDK.java.io.File arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;II)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning BigMajorVersion(Dova.JDK.javax.tools.JavaFileObject arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ConstantSVUID(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning DeclaredUsingPreview(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning DeprecatedAnnotationHasNoEffect(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning DirPathElementNotDirectory(Dova.JDK.java.io.File arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning DirPathElementNotDirectory(Dova.JDK.javax.tools.JavaFileObject arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning DirPathElementNotDirectory(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning DirPathElementNotFound(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning FileFromFuture(Dova.JDK.java.io.File arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning FileFromFuture(Dova.JDK.javax.tools.JavaFileObject arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning FileFromFuture(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[39], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;IIII)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning FutureAttr(Dova.JDK.com.sun.tools.javac.util.Name arg0, int arg1, int arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning HasBeenDeprecated(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[41], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning HasBeenDeprecatedForRemoval(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning HasBeenDeprecatedForRemovalModule(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[43], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning HasBeenDeprecatedModule(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[44], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ImproperSVUID(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[45], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning IncubatingModules(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[46], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning IneffectualSerialFieldEnum(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[47], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning IneffectualSerialMethodEnum(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[48], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning IneffectualSerialMethodExternalizable(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[49], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning IneffectualSerialMethodRecord(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[50], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning InexactNonVarargsCall(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[51], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning InvalidArchiveFile(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[52], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning IsPreview(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[53], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning IsPreviewReflective(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[54], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning LeaksNotAccessible(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[55], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning LeaksNotAccessibleNotRequiredTransitive(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[56], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning LeaksNotAccessibleUnexported(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[57], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning LeaksNotAccessibleUnexportedQualified(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[58], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/main/Option;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning LintOption(Dova.JDK.com.sun.tools.javac.main.Option arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[59], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning LocnUnknownFileOnModulePath(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[60], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning LongSVUID(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[61], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning MissingExplicitCtor(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[62], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning MissingSVUID(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[63], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/main/Option;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ModuleForOptionNotFound(Dova.JDK.com.sun.tools.javac.main.Option arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[64], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ModuleNotFound(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[65], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning NonSerializableInstanceFieldArray(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[66], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning OptionObsoleteSource(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[67], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/jvm/Target;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning OptionObsoleteTarget(Dova.JDK.com.sun.tools.javac.jvm.Target arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[68], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/jvm/Target;Lcom/sun/tools/javac/jvm/Target;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning OptionParametersUnsupported(Dova.JDK.com.sun.tools.javac.jvm.Target arg0, Dova.JDK.com.sun.tools.javac.jvm.Target arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[69], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning OutdirIsInExplodedModule(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[70], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning OverrideBridge(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[71], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning OverrideBridge(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[72], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning OverrideEqualsButNotHashcode(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[73], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning OverrideUncheckedRet(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[74], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning OverrideUncheckedRet(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[75], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning OverrideUncheckedThrown(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[76], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning OverrideUncheckedThrown(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[77], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning OverrideVarargsExtra(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[78], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning OverrideVarargsExtra(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[79], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning OverrideVarargsMissing(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[80], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning OverrideVarargsMissing(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[81], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning PackageEmptyOrNotFound(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[82], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning PathElementNotFound(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[83], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning PoorChoiceForModuleName(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[84], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(I)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning PositionOverflow(int arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[85], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning PotentiallyAmbiguousOverload(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.code.Symbol arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[86], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning PreviewFeatureUse(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[87], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning PreviewFeatureUse(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[88], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning PreviewFeatureUseClassfile(Dova.JDK.javax.tools.JavaFileObject arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[89], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning PreviewFeatureUsePlural(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[90], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning PreviewFeatureUsePlural(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[91], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProcAnnotationsWithoutProcessors(Dova.JDK.java.util.Set arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[92], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProcDuplicateOptionName(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[93], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProcDuplicateSupportedAnnotation(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[94], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProcFileCreateLastRound(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[95], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProcFileReopening(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[96], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProcIllegalFileName(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[97], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProcMalformedSupportedString(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[98], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProcPackageDoesNotExist(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[99], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/SourceVersion;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProcProcessorIncompatibleSourceVersion(Dova.JDK.javax.lang.model.SourceVersion arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[100], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProcRedundantTypesWithWildcard(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[101], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProcSuspiciousClassName(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[102], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProcTypeAlreadyExists(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[103], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProcTypeRecreate(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[104], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProcUnclosedTypeFiles(Dova.JDK.java.util.Set arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[105], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProcUnmatchedProcessorOptions(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[106], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/jvm/Profile;Lcom/sun/tools/javac/jvm/Target;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ProfileTargetConflict(Dova.JDK.com.sun.tools.javac.jvm.Profile arg0, Dova.JDK.com.sun.tools.javac.jvm.Target arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[107], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning RawClassUse(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[108], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning RedundantCast(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[109], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning SerialConcreteInstanceMethod(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[110], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning SerialMethodNoArgs(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[111], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning SerialMethodNotPrivate(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[112], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;I)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning SerialMethodOneArg(Dova.JDK.com.sun.tools.javac.util.Name arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[113], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning SerialMethodParameterType(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[114], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning SerialMethodStatic(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[115], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning SerialMethodUnexpectedException(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[116], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning SerialMethodUnexpectedReturnType(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[117], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning SerializableMissingAccessNoArgCtor(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[118], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning ServiceProvidedButNotExportedOrUsed(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[119], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning SourceNoBootclasspath(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[120], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning SourceNoSystemModulesPath(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[121], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/javac/jvm/Target;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning SourceTargetConflict(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.javac.jvm.Target arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[122], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning SunProprietary(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[123], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/javac/jvm/Target;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning TargetDefaultSourceConflict(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.javac.jvm.Target arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[124], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning TryResourceNotReferenced(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[125], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning UncheckedGenericArrayCreation(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[126], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning UncheckedVarargsNonReifiableType(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[127], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning UnexpectedArchiveFile(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[128], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning UnknownEnumConstant(Dova.JDK.javax.tools.JavaFileObject arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.util.Name arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[129], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning UnknownEnumConstantReason(Dova.JDK.javax.tools.JavaFileObject arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.util.Name arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[130], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning UnknownEnumConstantReason(Dova.JDK.javax.tools.JavaFileObject arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.util.Name arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[131], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning UnreachableCatch(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[132], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning UnreachableCatch1(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[133], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning VarargsRedundantTrustmeAnno(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[134], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning VarargsRedundantTrustmeAnno(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[135], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Warning;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning VarargsUnsafeUseVarargsParam(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[136], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Warning>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/resources/CompilerProperties$Errors;", "public static")]
	public partial class Errors
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Errors()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/resources/CompilerProperties$Errors;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AbstractMethCantHaveBody", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AddmodsAllModulePathInvalid", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AnnotationDeclNotAllowedHere", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AnnotationTypeNotApplicable", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AnnotationValueMustBeAnnotation", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AnnotationValueMustBeClassLiteral", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AnnotationValueMustBeNameValue", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AnnotationValueNotAllowableType", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AnonClassImplIntfNoArgs", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AnonClassImplIntfNoQualForNew", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AnonClassImplIntfNoTypeargs", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ArrayAndReceiver", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ArrayDimensionMissing", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AssertAsIdentifier", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AttributeValueMustBeConstant", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BadFunctionalIntfAnno", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BreakOutsideSwitchExpression", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BreakOutsideSwitchLoop", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CannotCreateArrayWithDiamond", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CannotCreateArrayWithTypeArguments", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CantAssignValToThis", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CantExtendIntfAnnotation", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CantInheritFromAnon", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CantReadFile", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CantSelectStaticClassFromParamType", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CatchWithoutTry", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ClassNotAllowed", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ConstExprReq", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ContOutsideLoop", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ContinueOutsideSwitchExpression", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DcBadEntity", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DcBadInlineTag", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DcGtExpected", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DcIdentifierExpected", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DcMalformedHtml", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DcMissingSemicolon", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DcNoContent", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DcNoTagName", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DcRefAnnotationsNotAllowed", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DcRefBadParens", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DcRefSyntaxError", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DcRefUnexpectedInput", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DcUnexpectedContent", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DcUnterminatedInlineTag", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DcUnterminatedSignature", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DcUnterminatedString", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DefaultAllowedInIntfAnnotationMember", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DotClassExpected", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DuplicateCaseLabel", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DuplicateDefaultLabel", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DuplicateTotalPattern", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ElseWithoutIf", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EmptyAArgument", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EmptyCharLit", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EnumAnnotationMustBeEnumConstant", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EnumAsIdentifier", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EnumCantBeInstantiated", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EnumConstantExpected", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EnumConstantNotExpected", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EnumLabelMustBeUnqualifiedEnum", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EnumNoFinalize", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EnumNoSubclassing", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EnumTypesNotExtensible", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Error", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ExpectedModule", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ExpectedModuleOrOpen", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ExpressionNotAllowableAsAnnotationValue", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FileSbOnSourceOrPatchPathForModule", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FinallyWithoutTry", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FlowsThroughFromPattern", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FlowsThroughToPattern", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FpNumberTooLarge", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FpNumberTooSmall", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GenericArrayCreation", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GenericThrowable", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IllegalArrayCreationBothDimensionAndInitialization", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IllegalDot", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IllegalEnumStaticRef", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IllegalEscChar", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IllegalForwardRef", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IllegalLineEndInCharLit", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IllegalNonasciiDigit", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IllegalParenthesizedExpression", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IllegalSelfRef", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IllegalStartOfExpr", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IllegalStartOfStmt", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IllegalStartOfType", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IllegalTextBlockOpen", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IllegalUnderscore", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IllegalUnicodeEsc", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ImproperlyFormedTypeInnerRawParam", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ImproperlyFormedTypeParamMissing", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "InitializerMustBeAbleToCompleteNormally", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "InitializerNotAllowed", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "InstanceInitializerNotAllowedInRecords", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IntfAnnotationMembersCantHaveParams", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IntfAnnotationMembersCantHaveTypeParams", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IntfExpectedHere", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IntfMethCantHaveBody", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IntfNotAllowedHere", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "InvalidAnnotationMemberType", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "InvalidBinaryNumber", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "InvalidHexNumber", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "InvalidMethDeclRetTypeReq", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "InvalidModuleDirective", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "InvalidYield", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IoException", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LambdaBodyNeitherValueNorVoidCompatible", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LimitCode", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LimitCodeTooLargeForTryStmt", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LimitDimensions", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LimitLocals", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LimitParameters", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LimitPool", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LimitPoolInClass", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LimitStack", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LimitString", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LocalEnum", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MalformedFpLit", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MatchBindingExists", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MethodDoesNotOverrideSuperclass", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MissingMethBodyOrDeclAbstract", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MissingRetStmt", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ModuleDeclSbInModuleInfoJava", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ModuleNotFoundOnModuleSourcePath", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ModulesourcepathMustBeSpecifiedWithDashMOption", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MultipleValuesForModuleSourcePath", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NameReservedForInternalUse", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NativeMethCantHaveBody", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NewNotAllowedInAnnotation", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NoAnnotationsOnDotClass", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NoIntfExpectedHere", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NoMatchEntry", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NoOpensUnlessStrong", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NoOutputDir", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NoPkgInModuleInfoJava", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NoSourceFiles", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NoSourceFilesClasses", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NoSwitchExpression", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NoSwitchExpressionQualify", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NonSealedOrSealedExpected", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NonSealedSealedOrFinalExpected", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NotExhaustive", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NotExhaustiveStatement", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NotInModuleOnModuleSourcePath", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NotStmt", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OutputDirMustBeSpecifiedWithDashMOption", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PatternDominated", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PatternExpected", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PkgAnnotationsSbInPackageInfoJava", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PrematureEof", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PreviewWithoutSourceOrRelease", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ProcCantCreateLoader", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ProcNoService", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ProcServiceProblem", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ProcessorpathNoProcessormodulepath", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ProfileBootclasspathConflict", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ReceiverParameterNotApplicableConstructorToplevelClass", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RecordCannotDeclareInstanceFields", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RecordCantDeclareFieldModifiers", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RecordComponentAndOldArraySyntax", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RecordHeaderExpected", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RecursiveCtorInvocation", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RepeatedAnnotationTarget", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RepeatedInterface", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RepeatedModifier", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RetOutsideMeth", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ReturnOutsideSwitchExpression", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RuleCompletesNormally", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SealedClassMustHaveSubclasses", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SealedOrNonSealedLocalClassesNotAllowed", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ServiceImplementationMustBeSubtypeOfServiceInterface", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ServiceImplementationProviderReturnMustBeSubtypeOfServiceInterface", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SignatureDoesntMatchIntf", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SignatureDoesntMatchSupertype", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SourcepathModulesourcepathConflict", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "StaticDeclarationNotAllowedInInnerClasses", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "StaticImpOnlyClassesAndInterfaces", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "StaticMethodsCannotBeAnnotatedWithOverride", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "StringConstReq", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SwitchCaseUnexpectedStatement", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SwitchExpressionCompletesNormally", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SwitchExpressionEmpty", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SwitchExpressionNoResultExpressions", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SwitchMixingCaseTypes", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ThisAsIdentifier", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ThrowsNotAllowedInIntfAnnotation", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TooManyModules", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TotalPatternAndDefault", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TryWithResourcesExprNeedsVar", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TryWithoutCatchFinallyOrResourceDecls", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TwoClassLoaders1", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TypeVarCantBeDeref", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TypeVarMayNotBeFollowedByOtherBounds", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TypeVarMoreThanOnce", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TypeVarMoreThanOnceInResult", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UnclosedCharLit", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UnclosedComment", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UnclosedStrLit", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UnclosedTextBlock", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UnderscoreAsIdentifier", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UnderscoreAsIdentifierInLambda", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UnexpectedLambda", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UnexpectedMref", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UnnamedPkgNotAllowedNamedModules", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UnreachableStmt", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VarargsAndOldArraySyntax", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VarargsAndReceiver", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VarargsMustBeLast", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VariableNotAllowed", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VoidNotAllowedHere", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WarningsAndWerror", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WrongReceiver", "Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "Expected", "(Lcom/sun/tools/javac/parser/Tokens$TokenKind;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ModNotAllowedHere", "(Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RestrictedTypeNotAllowedHere", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IntNumberTooLarge", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RestrictedTypeNotAllowedArray", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidLambdaParameterDeclaration", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "Expected3", "(Lcom/sun/tools/javac/parser/Tokens$TokenKind;Lcom/sun/tools/javac/parser/Tokens$TokenKind;Lcom/sun/tools/javac/parser/Tokens$TokenKind;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "Expected2", "(Lcom/sun/tools/javac/parser/Tokens$TokenKind;Lcom/sun/tools/javac/parser/Tokens$TokenKind;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "Orphaned", "(Lcom/sun/tools/javac/parser/Tokens$TokenKind;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadInitializer", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RestrictedTypeNotAllowedCompound", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RestrictedTypeNotAllowed", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ExpectedStr", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "Expected4", "(Lcom/sun/tools/javac/parser/Tokens$TokenKind;Lcom/sun/tools/javac/parser/Tokens$TokenKind;Lcom/sun/tools/javac/parser/Tokens$TokenKind;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidPermitsClause", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidCanonicalConstructorInRecord", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplyDiamond1", "(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplyDiamond1", "(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplyDiamond1", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplyDiamond1", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplyDiamond1", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplyDiamond1", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbol", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplySymbols", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantResolveArgs", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/lang/Void;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantResolveLocationArgsParams", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantResolveLocationArgsParams", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FeatureNotSupportedInSource", "(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FeatureNotSupportedInSource", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FeatureNotSupportedInSourcePlural", "(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FeatureNotSupportedInSourcePlural", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidMref", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidMref", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ModuleNameMismatch", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ModuleNonZeroOpens", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotDefAccessClassIntfCantAccess", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotDefAccessPackageCantAccess", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotDefAccessPackageCantAccess", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotDefPublicCantAccess", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PackageNotVisible", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PackageNotVisible", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProbFoundReq", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProbFoundReq", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RefAmbiguous", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ReportAccess", "(Lcom/sun/tools/javac/code/Symbol;Ljava/util/Set;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "WrongNumberTypeArgs", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FileNotFound", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FileNotFile", "(Ljava/lang/Object;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidPath", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidTarget", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidProfile", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidAKey", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OptionTooMany", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidFlag", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ReqArg", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NoValueForOption", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RepeatedValueForModuleSourcePath", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RepeatedValueForPatchModule", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadValueForOption", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidSource", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ErrorWritingFile", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotDefAccessClassIntfCantAccessReason", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotDefAccessClassIntfCantAccessReason", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IllegalRefToRestrictedType", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AbstractCantBeAccessedDirectly", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IllegalDefaultSuperCall", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IllegalDefaultSuperCall", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IllegalDefaultSuperCall", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IllegalDefaultSuperCall", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotEnclClass", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "EnclClassRequired", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantRefBeforeCtorCalled", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantRefBeforeCtorCalled", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantResolveLocationArgs", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/lang/Void;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantResolveLocationArgs", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/lang/Void;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcMessager", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PluginNotFound", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IllegalArgumentForOption", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UnsupportedEncoding", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IllegalCharForEncoding", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SameBinaryName", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DuplicateClass", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UnexpectedType", "(Ljava/util/Set;Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DefaultOverridesObjectMember", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidAccessorMethodInRecord", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FirstStatementMustBeCallToAnotherConstructor", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PackageInOtherModule", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CallToSuperNotAllowedInEnumCtor", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantInferLocalVarType", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantInferLocalVarType", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IllegalRecordComponentName", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ForeachNotApplicableToType", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ForeachNotApplicableToType", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "LabelAlreadyInUse", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "TryResourceMayNotBeAssigned", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantAssignValToFinalVar", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantInheritFromFinal", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ClassPublicShouldBeInFile", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ConstantLabelNotCompatible", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotLoopLabel", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UndefLabel", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NoSuperclass", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IllegalQualNotIcls", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CallMustBeFirstStmtInCtor", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "QualifiedNewOfStaticClass", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AbstractCantBeInstantiated", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IllegalInitializerForType", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncompatibleThrownTypesInMref", "(Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncomparableTypes", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InstanceofPatternNoSubtype", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InstanceofReifiableNotSafe", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ArrayReqButFound", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantDeref", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IllegalStaticIntfMethCall", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "TypeDoesntTakeParams", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "MulticatchTypesMustBeDisjoint", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "LocalClassesCantExtendSealed", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ClassInUnnamedModuleCantExtendSealedInDiffPackage", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ClassInModuleCantExtendSealedInDiffModule", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NonSealedWithNoSealedSupertype", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantInheritFromSealed", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IntfAnnotationCantHaveTypeParams", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IclsCantHaveStaticDecl", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadNameForOption", "(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IsPreview", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ModuleNotFound", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PackageEmptyOrNotFound", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AddExportsWithRelease", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AddReadsWithRelease", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AlreadyAnnotated", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AlreadyDefined", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AlreadyDefinedInClinit", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AlreadyDefinedSingleImport", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AlreadyDefinedStaticSingleImport", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AlreadyDefinedThisUnit", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AnnotationMissingDefaultValue", "(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AnnotationMissingDefaultValue1", "(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AnnotationNotValidForType", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AnnotationTypeNotApplicableToType", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AnonymousDiamondMethodDoesNotOverrideSuperclass", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "AnonymousDiamondMethodDoesNotOverrideSuperclass", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ArrayAndVarargs", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadFunctionalIntfAnno1", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "BadFunctionalIntfAnno1", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CannotGenerateClass", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantAccess", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantAccess", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplyDiamond", "(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/lang/Void;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantApplyDiamond", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/lang/Void;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantInheritDiffArg", "(Lcom/sun/tools/javac/code/Symbol;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantRefNonEffectivelyFinalVar", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantRefNonEffectivelyFinalVar", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantResolve", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/lang/Void;Ljava/lang/Void;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantResolveArgsParams", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantResolveLocation", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/lang/Void;Ljava/lang/Void;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantResolveLocation", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/lang/Void;Ljava/lang/Void;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantTypeAnnotateScoping", "(Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CantTypeAnnotateScoping1", "(Lcom/sun/tools/javac/code/Attribute$Compound;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ClashWithPkgOfSameName", "(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ClassCantWrite", "(Lcom/sun/tools/javac/code/Symbol;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ConcreteInheritanceConflict", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ConflictingExports", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ConflictingExportsToModule", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ConflictingOpens", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ConflictingOpensToModule", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CyclicAnnotationElement", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CyclicInheritance", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CyclicInheritance", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CyclicRequires", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DoesNotOverrideAbstract", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DoesntExist", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DuplicateAnnotationInvalidRepeated", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DuplicateAnnotationMemberValue", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DuplicateModule", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DuplicateModuleOnPath", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DuplicateProvides", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DuplicateRequires", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DuplicateUses", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ErrorReadingFile", "(Ljava/io/File;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ErrorReadingFile", "(Ljava/nio/file/Path;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ErrorReadingFile", "(Ljavax/tools/JavaFileObject;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ExceptAlreadyCaught", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ExceptNeverThrownInTry", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FileNotDirectory", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FilePatchedAndMsp", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FinalParameterMayNotBeAssigned", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IllegalChar", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IllegalCombinationOfModifiers", "(Ljava/util/Set;Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ImportRequiresCanonical", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncorrectConstructorReceiverName", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncorrectConstructorReceiverType", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncorrectReceiverName", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IncorrectReceiverType", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IntfAnnotationMemberClash", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidModuleSpecifier", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidRepeatableAnnotation", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidRepeatableAnnotationElemNondefault", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidRepeatableAnnotationElemNondefault", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidRepeatableAnnotationIncompatibleTarget", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidRepeatableAnnotationInvalidValue", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidRepeatableAnnotationMultipleValues", "(Lcom/sun/tools/javac/code/Type;I)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidRepeatableAnnotationNoValue", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidRepeatableAnnotationNoValue", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidRepeatableAnnotationNotApplicable", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidRepeatableAnnotationNotApplicableInContext", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidRepeatableAnnotationNotDocumented", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidRepeatableAnnotationNotInherited", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidRepeatableAnnotationRepeatedAndContainerPresent", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidRepeatableAnnotationRetention", "(Lcom/sun/tools/javac/code/Symbol;Ljava/lang/String;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidRepeatableAnnotationValueReturn", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidRepeatableAnnotationValueReturn", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "InvalidSupertypeRecord", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "LimitStringOverflow", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "LocalVarAccessedFromIclsNeedsFinal", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "LocnBadModuleInfo", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "LocnCantGetModuleNameForJar", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "LocnCantReadDirectory", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "LocnCantReadFile", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "LocnInvalidArgForXpatch", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "LocnModuleInfoNotAllowedOnPatchPath", "(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ModifierNotAllowedHere", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ModuleNotFoundInModuleSourcePath", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "MultiModuleOutdirCannotBeExplodedModule", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "MulticatchParameterMayNotBeAssigned", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NameClashSameErasure", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NameClashSameErasureNoHide", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NameClashSameErasureNoOverride", "(Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NameClashSameErasureNoOverride1", "(Ljava/lang/String;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NoAnnotationMember", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NoEnclInstanceOfTypeInScope", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NoZipfsForArchive", "(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NonStaticCantBeRef", "(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotAnnotationType", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotDefPublic", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotInProfile", "(Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Object;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotWithinBounds", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "NotWithinBounds", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OperatorCantBeApplied", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OperatorCantBeApplied1", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OptionNotAllowedWithTarget", "(Lcom/sun/tools/javac/main/Option;Lcom/sun/tools/javac/jvm/Target;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OptionRemovedSource", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OptionRemovedTarget", "(Lcom/sun/tools/javac/jvm/Target;Lcom/sun/tools/javac/jvm/Target;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideIncompatibleRet", "(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideIncompatibleRet", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideMeth", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideMeth", "(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideMethDoesntThrow", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideMethDoesntThrow", "(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideStatic", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideStatic", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideWeakerAccess", "(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideWeakerAccess", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideWeakerAccess", "(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "OverrideWeakerAccess", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PackageClashFromRequires", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PackageClashFromRequiresInUnnamed", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PkgClashesWithClassOfSameName", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PreviewFeatureDisabled", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PreviewFeatureDisabled", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PreviewFeatureDisabledClassfile", "(Ljavax/tools/JavaFileObject;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PreviewFeatureDisabledPlural", "(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PreviewFeatureDisabledPlural", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "PreviewNotLatest", "(Ljava/lang/String;Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcBadConfigFile", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcCantAccess", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcCantAccess", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcCantAccess1", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcCantAccess1", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcCantFindClass", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcCantLoadClass", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcNoExplicitAnnotationProcessingRequested", "(Ljava/util/Collection;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcProcessorBadOptionName", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcProcessorCantInstantiate", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcProcessorNotFound", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcProcessorWrongType", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ReleaseBootclasspathConflict", "(Lcom/sun/tools/javac/main/Option;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RepeatedProvidesForService", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ServiceDefinitionIsEnum", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ServiceImplementationDoesntHaveANoArgsConstructor", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ServiceImplementationIsAbstract", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ServiceImplementationIsInner", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ServiceImplementationNoArgsConstructorNotPublic", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ServiceImplementationNotInRightModule", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "SourceCantOverwriteInputFile", "(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "StackSimError", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "TooManyPatchedModules", "(Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "TryWithResourcesExprEffectivelyFinalVar", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "TwoClassLoaders2", "(Ljava/net/URL;Ljava/net/URL;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "TypeFoundReq", "(Ljava/lang/Object;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "TypeFoundReq", "(Ljava/lang/Object;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "TypesIncompatible", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UnmatchedQuote", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UnreportedExceptionDefaultConstructor", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UnreportedExceptionImplicitClose", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UnreportedExceptionNeedToCatchOrThrow", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "UnsupportedReleaseVersion", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VarMightAlreadyBeAssigned", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VarMightBeAssignedInLoop", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VarMightNotHaveBeenInitialized", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VarNotInitializedInDefaultConstructor", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VarargsInvalidTrustmeAnno", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "VarargsInvalidTrustmeAnno", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DuplicateAnnotationMissingContainer", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AbstractMethCantHaveBody_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AddmodsAllModulePathInvalid_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AnnotationDeclNotAllowedHere_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AnnotationTypeNotApplicable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AnnotationValueMustBeAnnotation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AnnotationValueMustBeClassLiteral_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AnnotationValueMustBeNameValue_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AnnotationValueNotAllowableType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AnonClassImplIntfNoArgs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AnonClassImplIntfNoQualForNew_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AnonClassImplIntfNoTypeargs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ArrayAndReceiver_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ArrayDimensionMissing_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AssertAsIdentifier_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AttributeValueMustBeConstant_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error BadFunctionalIntfAnno_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error BreakOutsideSwitchExpression_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error BreakOutsideSwitchLoop_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CannotCreateArrayWithDiamond_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CannotCreateArrayWithTypeArguments_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantAssignValToThis_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantExtendIntfAnnotation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantInheritFromAnon_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantReadFile_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantSelectStaticClassFromParamType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CatchWithoutTry_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ClassNotAllowed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ConstExprReq_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ContOutsideLoop_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ContinueOutsideSwitchExpression_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DcBadEntity_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DcBadInlineTag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DcGtExpected_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DcIdentifierExpected_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DcMalformedHtml_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DcMissingSemicolon_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DcNoContent_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DcNoTagName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DcRefAnnotationsNotAllowed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DcRefBadParens_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DcRefSyntaxError_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DcRefUnexpectedInput_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DcUnexpectedContent_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DcUnterminatedInlineTag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DcUnterminatedSignature_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DcUnterminatedString_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DefaultAllowedInIntfAnnotationMember_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DotClassExpected_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DuplicateCaseLabel_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DuplicateDefaultLabel_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DuplicateTotalPattern_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ElseWithoutIf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error EmptyAArgument_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error EmptyCharLit_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error EnumAnnotationMustBeEnumConstant_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error EnumAsIdentifier_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[55]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[55], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error EnumCantBeInstantiated_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[56]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[56], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error EnumConstantExpected_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error EnumConstantNotExpected_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error EnumLabelMustBeUnqualifiedEnum_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error EnumNoFinalize_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error EnumNoSubclassing_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[61]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[61], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error EnumTypesNotExtensible_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[62]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[62], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error Error_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[63]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[63], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ExpectedModule_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ExpectedModuleOrOpen_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ExpressionNotAllowableAsAnnotationValue_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error FileSbOnSourceOrPatchPathForModule_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error FinallyWithoutTry_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[68]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[68], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error FlowsThroughFromPattern_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[69]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[69], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error FlowsThroughToPattern_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error FpNumberTooLarge_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[71]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[71], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error FpNumberTooSmall_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[72]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[72], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error GenericArrayCreation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[73]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[73], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error GenericThrowable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[74]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[74], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalArrayCreationBothDimensionAndInitialization_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[75]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[75], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalDot_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[76]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[76], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalEnumStaticRef_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[77]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[77], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalEscChar_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[78]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[78], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalForwardRef_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[79]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[79], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalLineEndInCharLit_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[80]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[80], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalNonasciiDigit_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[81]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[81], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalParenthesizedExpression_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[82]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[82], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalSelfRef_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[83]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[83], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalStartOfExpr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[84]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[84], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalStartOfStmt_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[85]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[85], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalStartOfType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[86]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[86], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalTextBlockOpen_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[87]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[87], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalUnderscore_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[88]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[88], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalUnicodeEsc_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[89]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[89], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ImproperlyFormedTypeInnerRawParam_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[90]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[90], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ImproperlyFormedTypeParamMissing_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[91]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[91], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InitializerMustBeAbleToCompleteNormally_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[92]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[92], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InitializerNotAllowed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[93]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[93], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InstanceInitializerNotAllowedInRecords_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[94]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[94], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IntfAnnotationMembersCantHaveParams_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[95]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[95], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IntfAnnotationMembersCantHaveTypeParams_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[96]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[96], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IntfExpectedHere_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[97]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[97], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IntfMethCantHaveBody_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[98]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[98], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IntfNotAllowedHere_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[99]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[99], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidAnnotationMemberType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[100]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[100], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidBinaryNumber_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[101]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[101], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidHexNumber_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[102]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[102], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidMethDeclRetTypeReq_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[103]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[103], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidModuleDirective_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[104]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[104], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidYield_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[105]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[105], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IoException_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[106]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[106], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error LambdaBodyNeitherValueNorVoidCompatible_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[107]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[107], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error LimitCode_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[108]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[108], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error LimitCodeTooLargeForTryStmt_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[109]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[109], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error LimitDimensions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[110]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[110], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error LimitLocals_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[111]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[111], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error LimitParameters_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[112]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[112], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error LimitPool_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[113]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[113], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error LimitPoolInClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[114]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[114], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error LimitStack_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[115]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[115], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error LimitString_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[116]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[116], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error LocalEnum_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[117]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[117], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error MalformedFpLit_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[118]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[118], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error MatchBindingExists_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[119]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[119], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error MethodDoesNotOverrideSuperclass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[120]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[120], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error MissingMethBodyOrDeclAbstract_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[121]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[121], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error MissingRetStmt_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[122]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[122], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ModuleDeclSbInModuleInfoJava_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[123]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[123], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ModuleNotFoundOnModuleSourcePath_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[124]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[124], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ModulesourcepathMustBeSpecifiedWithDashMOption_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[125]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[125], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error MultipleValuesForModuleSourcePath_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[126]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[126], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NameReservedForInternalUse_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[127]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[127], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NativeMethCantHaveBody_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[128]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[128], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NewNotAllowedInAnnotation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[129]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[129], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NoAnnotationsOnDotClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[130]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[130], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NoIntfExpectedHere_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[131]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[131], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NoMatchEntry_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[132]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[132], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NoOpensUnlessStrong_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[133]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[133], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NoOutputDir_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[134]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[134], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NoPkgInModuleInfoJava_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[135]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[135], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NoSourceFiles_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[136]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[136], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NoSourceFilesClasses_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[137]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[137], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NoSwitchExpression_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[138]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[138], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NoSwitchExpressionQualify_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[139]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[139], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NonSealedOrSealedExpected_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[140]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[140], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NonSealedSealedOrFinalExpected_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[141]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[141], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NotExhaustive_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[142]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[142], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NotExhaustiveStatement_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[143]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[143], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NotInModuleOnModuleSourcePath_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[144]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[144], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NotStmt_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[145]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[145], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error OutputDirMustBeSpecifiedWithDashMOption_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[146]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[146], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error PatternDominated_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[147]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[147], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error PatternExpected_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[148]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[148], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error PkgAnnotationsSbInPackageInfoJava_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[149]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[149], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error PrematureEof_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[150]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[150], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error PreviewWithoutSourceOrRelease_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[151]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[151], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ProcCantCreateLoader_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[152]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[152], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ProcNoService_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[153]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[153], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ProcServiceProblem_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[154]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[154], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ProcessorpathNoProcessormodulepath_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[155]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[155], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ProfileBootclasspathConflict_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[156]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[156], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ReceiverParameterNotApplicableConstructorToplevelClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[157]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[157], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error RecordCannotDeclareInstanceFields_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[158]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[158], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error RecordCantDeclareFieldModifiers_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[159]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[159], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error RecordComponentAndOldArraySyntax_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[160]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[160], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error RecordHeaderExpected_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[161]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[161], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error RecursiveCtorInvocation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[162]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[162], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error RepeatedAnnotationTarget_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[163]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[163], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error RepeatedInterface_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[164]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[164], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error RepeatedModifier_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[165]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[165], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error RetOutsideMeth_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[166]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[166], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ReturnOutsideSwitchExpression_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[167]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[167], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error RuleCompletesNormally_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[168]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[168], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error SealedClassMustHaveSubclasses_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[169]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[169], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error SealedOrNonSealedLocalClassesNotAllowed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[170]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[170], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ServiceImplementationMustBeSubtypeOfServiceInterface_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[171]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[171], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ServiceImplementationProviderReturnMustBeSubtypeOfServiceInterface_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[172]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[172], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error SignatureDoesntMatchIntf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[173]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[173], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error SignatureDoesntMatchSupertype_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[174]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[174], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error SourcepathModulesourcepathConflict_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[175]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[175], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error StaticDeclarationNotAllowedInInnerClasses_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[176]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[176], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error StaticImpOnlyClassesAndInterfaces_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[177]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[177], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error StaticMethodsCannotBeAnnotatedWithOverride_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[178]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[178], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error StringConstReq_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[179]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[179], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error SwitchCaseUnexpectedStatement_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[180]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[180], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error SwitchExpressionCompletesNormally_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[181]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[181], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error SwitchExpressionEmpty_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[182]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[182], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error SwitchExpressionNoResultExpressions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[183]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[183], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error SwitchMixingCaseTypes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[184]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[184], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ThisAsIdentifier_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[185]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[185], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ThrowsNotAllowedInIntfAnnotation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[186]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[186], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error TooManyModules_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[187]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[187], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error TotalPatternAndDefault_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[188]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[188], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error TryWithResourcesExprNeedsVar_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[189]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[189], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error TryWithoutCatchFinallyOrResourceDecls_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[190]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[190], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error TwoClassLoaders1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[191]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[191], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error TypeVarCantBeDeref_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[192]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[192], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error TypeVarMayNotBeFollowedByOtherBounds_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[193]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[193], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error TypeVarMoreThanOnce_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[194]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[194], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error TypeVarMoreThanOnceInResult_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[195]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[195], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error UnclosedCharLit_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[196]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[196], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error UnclosedComment_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[197]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[197], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error UnclosedStrLit_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[198]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[198], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error UnclosedTextBlock_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[199]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[199], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error UnderscoreAsIdentifier_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[200]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[200], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error UnderscoreAsIdentifierInLambda_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[201]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[201], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error UnexpectedLambda_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[202]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[202], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error UnexpectedMref_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[203]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[203], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error UnnamedPkgNotAllowedNamedModules_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[204]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[204], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error UnreachableStmt_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[205]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[205], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error VarargsAndOldArraySyntax_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[206]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[206], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error VarargsAndReceiver_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[207]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[207], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error VarargsMustBeLast_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[208]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[208], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error VariableNotAllowed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[209]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[209], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error VoidNotAllowedHere_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[210]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[210], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error WarningsAndWerror_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[211]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[211], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error WrongReceiver_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[212]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[212], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Errors(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Errors() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/resources/CompilerProperties$Errors;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/Tokens$TokenKind;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error Expected(Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ModNotAllowedHere(Dova.JDK.java.util.Set arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error RestrictedTypeNotAllowedHere(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IntNumberTooLarge(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error RestrictedTypeNotAllowedArray(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidLambdaParameterDeclaration(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/Tokens$TokenKind;Lcom/sun/tools/javac/parser/Tokens$TokenKind;Lcom/sun/tools/javac/parser/Tokens$TokenKind;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error Expected3(Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind arg0, Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind arg1, Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/Tokens$TokenKind;Lcom/sun/tools/javac/parser/Tokens$TokenKind;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error Expected2(Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind arg0, Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/Tokens$TokenKind;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error Orphaned(Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error BadInitializer(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error RestrictedTypeNotAllowedCompound(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error RestrictedTypeNotAllowed(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Source arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ExpectedStr(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/Tokens$TokenKind;Lcom/sun/tools/javac/parser/Tokens$TokenKind;Lcom/sun/tools/javac/parser/Tokens$TokenKind;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error Expected4(Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind arg0, Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind arg1, Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind arg2, Dova.JDK.java.lang.String arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidPermitsClause(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidCanonicalConstructorInRecord(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplyDiamond1(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplyDiamond1(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplyDiamond1(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplyDiamond1(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplyDiamond1(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplyDiamond1(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.util.List arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.util.List arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.util.List arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.util.List arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/util/List;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplySymbol(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Type arg5, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/util/Name;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplySymbols(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.util.List arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/lang/Void;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantResolveArgs(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.lang.Void arg2, Dova.JDK.java.util.List arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[41], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantResolveLocationArgsParams(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg4)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantResolveLocationArgsParams(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg4)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[43], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error FeatureNotSupportedInSource(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[44], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error FeatureNotSupportedInSource(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[45], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error FeatureNotSupportedInSourcePlural(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[46], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error FeatureNotSupportedInSourcePlural(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[47], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidMref(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[48], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidMref(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[49], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ModuleNameMismatch(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[50], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ModuleNonZeroOpens(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[51], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NotDefAccessClassIntfCantAccess(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[52], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NotDefAccessPackageCantAccess(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[53], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NotDefAccessPackageCantAccess(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[54], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NotDefPublicCantAccess(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[55], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error PackageNotVisible(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[56], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error PackageNotVisible(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[57], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ProbFoundReq(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[58], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ProbFoundReq(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[59], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error RefAmbiguous(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.code.Symbol arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg4, Dova.JDK.com.sun.tools.javac.code.Symbol arg5, Dova.JDK.com.sun.tools.javac.code.Symbol arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[60], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Ljava/util/Set;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ReportAccess(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.java.util.Set arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[61], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error WrongNumberTypeArgs(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[62], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error FileNotFound(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[63], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error FileNotFile(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[64], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidPath(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[65], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidTarget(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[66], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidProfile(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[67], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidAKey(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[68], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error OptionTooMany(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[69], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidFlag(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[70], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ReqArg(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[71], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NoValueForOption(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[72], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error RepeatedValueForModuleSourcePath(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[73], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error RepeatedValueForPatchModule(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[74], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error BadValueForOption(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[75], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidSource(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[76], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ErrorWritingFile(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[77], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NotDefAccessClassIntfCantAccessReason(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[78], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NotDefAccessClassIntfCantAccessReason(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[79], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalRefToRestrictedType(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[80], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AbstractCantBeAccessedDirectly(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[81], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalDefaultSuperCall(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[82], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalDefaultSuperCall(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[83], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalDefaultSuperCall(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[84], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalDefaultSuperCall(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[85], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NotEnclClass(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[86], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error EnclClassRequired(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[87], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantRefBeforeCtorCalled(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[88], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantRefBeforeCtorCalled(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[89], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/lang/Void;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantResolveLocationArgs(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.lang.Void arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg4)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[90], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/lang/Void;Ljava/util/List;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantResolveLocationArgs(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.lang.Void arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg4)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[91], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ProcMessager(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[92], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error PluginNotFound(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[93], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalArgumentForOption(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[94], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error UnsupportedEncoding(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[95], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalCharForEncoding(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[96], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error SameBinaryName(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[97], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DuplicateClass(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[98], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Set;Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error UnexpectedType(Dova.JDK.java.util.Set arg0, Dova.JDK.java.util.Set arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[99], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DefaultOverridesObjectMember(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[100], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidAccessorMethodInRecord(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[101], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error FirstStatementMustBeCallToAnotherConstructor(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[102], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error PackageInOtherModule(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[103], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CallToSuperNotAllowedInEnumCtor(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[104], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantInferLocalVarType(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[105], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantInferLocalVarType(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[106], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalRecordComponentName(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[107], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ForeachNotApplicableToType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[108], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ForeachNotApplicableToType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[109], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error LabelAlreadyInUse(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[110], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error TryResourceMayNotBeAssigned(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[111], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantAssignValToFinalVar(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[112], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantInheritFromFinal(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[113], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ClassPublicShouldBeInFile(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[114], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ConstantLabelNotCompatible(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[115], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NotLoopLabel(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[116], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error UndefLabel(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[117], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NoSuperclass(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[118], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalQualNotIcls(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[119], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CallMustBeFirstStmtInCtor(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[120], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error QualifiedNewOfStaticClass(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[121], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AbstractCantBeInstantiated(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[122], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalInitializerForType(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[123], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IncompatibleThrownTypesInMref(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[124], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IncomparableTypes(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[125], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InstanceofPatternNoSubtype(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[126], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InstanceofReifiableNotSafe(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[127], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ArrayReqButFound(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[128], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantDeref(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[129], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalStaticIntfMethCall(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[130], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error TypeDoesntTakeParams(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[131], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error MulticatchTypesMustBeDisjoint(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[132], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error LocalClassesCantExtendSealed(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[133], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ClassInUnnamedModuleCantExtendSealedInDiffPackage(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[134], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ClassInModuleCantExtendSealedInDiffModule(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[135], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NonSealedWithNoSealedSupertype(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[136], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantInheritFromSealed(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[137], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IntfAnnotationCantHaveTypeParams(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[138], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IclsCantHaveStaticDecl(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[139], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/main/Option;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error BadNameForOption(Dova.JDK.com.sun.tools.javac.main.Option arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[140], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IsPreview(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[141], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ModuleNotFound(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[142], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error PackageEmptyOrNotFound(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[143], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AddExportsWithRelease(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[144], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AddReadsWithRelease(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[145], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AlreadyAnnotated(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[146], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AlreadyDefined(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg2, Dova.JDK.com.sun.tools.javac.code.Symbol arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[147], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AlreadyDefinedInClinit(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg2, Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg3, Dova.JDK.com.sun.tools.javac.code.Symbol arg4)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[148], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AlreadyDefinedSingleImport(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[149], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AlreadyDefinedStaticSingleImport(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[150], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AlreadyDefinedThisUnit(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[151], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AnnotationMissingDefaultValue(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[152], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AnnotationMissingDefaultValue1(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[153], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AnnotationNotValidForType(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[154], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AnnotationTypeNotApplicableToType(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[155], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AnonymousDiamondMethodDoesNotOverrideSuperclass(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[156], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error AnonymousDiamondMethodDoesNotOverrideSuperclass(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[157], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ArrayAndVarargs(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[158], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error BadFunctionalIntfAnno1(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[159], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error BadFunctionalIntfAnno1(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[160], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CannotGenerateClass(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[161], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantAccess(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[162], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantAccess(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[163], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/lang/Void;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplyDiamond(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[164], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/lang/Void;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantApplyDiamond(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[165], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantInheritDiffArg(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[166], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantRefNonEffectivelyFinalVar(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[167], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantRefNonEffectivelyFinalVar(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[168], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/lang/Void;Ljava/lang/Void;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantResolve(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.lang.Void arg2, Dova.JDK.java.lang.Void arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[169], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantResolveArgsParams(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[170], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/lang/Void;Ljava/lang/Void;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantResolveLocation(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.lang.Void arg2, Dova.JDK.java.lang.Void arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg4)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[171], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/util/Name;Ljava/lang/Void;Ljava/lang/Void;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantResolveLocation(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.java.lang.Void arg2, Dova.JDK.java.lang.Void arg3, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg4)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[172], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantTypeAnnotateScoping(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[173], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Attribute$Compound;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CantTypeAnnotateScoping1(Dova.JDK.com.sun.tools.javac.code.Attribute.Compound arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[174], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ClashWithPkgOfSameName(Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[175], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ClassCantWrite(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[176], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ConcreteInheritanceConflict(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.code.Type arg3, Dova.JDK.com.sun.tools.javac.code.Type arg4)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[177], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ConflictingExports(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[178], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ConflictingExportsToModule(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[179], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ConflictingOpens(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[180], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ConflictingOpensToModule(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[181], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CyclicAnnotationElement(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[182], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CyclicInheritance(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[183], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CyclicInheritance(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[184], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error CyclicRequires(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[185], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DoesNotOverrideAbstract(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[186], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DoesntExist(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[187], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DuplicateAnnotationInvalidRepeated(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[188], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DuplicateAnnotationMemberValue(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[189], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DuplicateModule(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[190], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DuplicateModuleOnPath(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[191], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DuplicateProvides(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[192], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DuplicateRequires(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[193], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DuplicateUses(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[194], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ErrorReadingFile(Dova.JDK.java.io.File arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[195], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ErrorReadingFile(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[196], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ErrorReadingFile(Dova.JDK.javax.tools.JavaFileObject arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[197], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ExceptAlreadyCaught(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[198], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ExceptNeverThrownInTry(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[199], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error FileNotDirectory(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[200], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error FilePatchedAndMsp(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[201], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error FinalParameterMayNotBeAssigned(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[202], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalChar(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[203], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Set;Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IllegalCombinationOfModifiers(Dova.JDK.java.util.Set arg0, Dova.JDK.java.util.Set arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[204], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ImportRequiresCanonical(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[205], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IncorrectConstructorReceiverName(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[206], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IncorrectConstructorReceiverType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[207], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IncorrectReceiverName(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[208], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IncorrectReceiverType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[209], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error IntfAnnotationMemberClash(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[210], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidModuleSpecifier(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[211], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidRepeatableAnnotation(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[212], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidRepeatableAnnotationElemNondefault(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[213], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidRepeatableAnnotationElemNondefault(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[214], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidRepeatableAnnotationIncompatibleTarget(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[215], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidRepeatableAnnotationInvalidValue(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[216], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;I)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidRepeatableAnnotationMultipleValues(Dova.JDK.com.sun.tools.javac.code.Type arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[217], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidRepeatableAnnotationNoValue(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[218], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidRepeatableAnnotationNoValue(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[219], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidRepeatableAnnotationNotApplicable(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[220], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidRepeatableAnnotationNotApplicableInContext(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[221], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidRepeatableAnnotationNotDocumented(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[222], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidRepeatableAnnotationNotInherited(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[223], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidRepeatableAnnotationRepeatedAndContainerPresent(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[224], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Ljava/lang/String;Lcom/sun/tools/javac/code/Symbol;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidRepeatableAnnotationRetention(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.java.lang.String arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[225], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidRepeatableAnnotationValueReturn(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[226], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidRepeatableAnnotationValueReturn(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[227], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error InvalidSupertypeRecord(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[228], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error LimitStringOverflow(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[229], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error LocalVarAccessedFromIclsNeedsFinal(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[230], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error LocnBadModuleInfo(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[231], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error LocnCantGetModuleNameForJar(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[232], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error LocnCantReadDirectory(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[233], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error LocnCantReadFile(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[234], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error LocnInvalidArgForXpatch(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[235], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error LocnModuleInfoNotAllowedOnPatchPath(Dova.JDK.javax.tools.JavaFileObject arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[236], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ModifierNotAllowedHere(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[237], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ModuleNotFoundInModuleSourcePath(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[238], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error MultiModuleOutdirCannotBeExplodedModule(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[239], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error MulticatchParameterMayNotBeAssigned(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[240], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NameClashSameErasure(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[241], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NameClashSameErasureNoHide(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.code.Symbol arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[242], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NameClashSameErasureNoOverride(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.java.util.List arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.util.Name arg3, Dova.JDK.java.util.List arg4, Dova.JDK.com.sun.tools.javac.code.Symbol arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[243], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/Name;Ljava/util/List;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NameClashSameErasureNoOverride1(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.Name arg2, Dova.JDK.java.util.List arg3, Dova.JDK.com.sun.tools.javac.code.Symbol arg4, Dova.JDK.com.sun.tools.javac.util.Name arg5, Dova.JDK.java.util.List arg6, Dova.JDK.com.sun.tools.javac.code.Symbol arg7)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[244], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NoAnnotationMember(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[245], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NoEnclInstanceOfTypeInScope(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[246], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NoZipfsForArchive(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[247], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NonStaticCantBeRef(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[248], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NotAnnotationType(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[249], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NotDefPublic(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[250], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Ljava/lang/Object;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NotInProfile(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[251], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NotWithinBounds(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[252], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error NotWithinBounds(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[253], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error OperatorCantBeApplied(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[254], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error OperatorCantBeApplied1(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[255], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/main/Option;Lcom/sun/tools/javac/jvm/Target;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error OptionNotAllowedWithTarget(Dova.JDK.com.sun.tools.javac.main.Option arg0, Dova.JDK.com.sun.tools.javac.jvm.Target arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[256], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error OptionRemovedSource(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[257], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/jvm/Target;Lcom/sun/tools/javac/jvm/Target;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error OptionRemovedTarget(Dova.JDK.com.sun.tools.javac.jvm.Target arg0, Dova.JDK.com.sun.tools.javac.jvm.Target arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[258], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error OverrideIncompatibleRet(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[259], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error OverrideIncompatibleRet(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[260], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error OverrideMeth(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0, Dova.JDK.java.util.Set arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[261], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error OverrideMeth(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.java.util.Set arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[262], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error OverrideMethDoesntThrow(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[263], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error OverrideMethDoesntThrow(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[264], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error OverrideStatic(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[265], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error OverrideStatic(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[266], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error OverrideWeakerAccess(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.java.util.Set arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[267], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error OverrideWeakerAccess(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0, Dova.JDK.java.util.Set arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[268], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error OverrideWeakerAccess(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[269], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error OverrideWeakerAccess(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[270], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error PackageClashFromRequires(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.com.sun.tools.javac.code.Symbol arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[271], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error PackageClashFromRequiresInUnnamed(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[272], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error PkgClashesWithClassOfSameName(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[273], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error PreviewFeatureDisabled(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[274], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error PreviewFeatureDisabled(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[275], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error PreviewFeatureDisabledClassfile(Dova.JDK.javax.tools.JavaFileObject arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[276], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error PreviewFeatureDisabledPlural(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[277], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error PreviewFeatureDisabledPlural(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[278], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/javac/code/Source;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error PreviewNotLatest(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.javac.code.Source arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[279], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ProcBadConfigFile(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[280], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ProcCantAccess(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[281], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ProcCantAccess(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[282], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ProcCantAccess1(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[283], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ProcCantAccess1(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[284], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ProcCantFindClass(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[285], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ProcCantLoadClass(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[286], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ProcNoExplicitAnnotationProcessingRequested(Dova.JDK.java.util.Collection arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[287], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ProcProcessorBadOptionName(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[288], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ProcProcessorCantInstantiate(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[289], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ProcProcessorNotFound(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[290], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ProcProcessorWrongType(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[291], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/main/Option;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ReleaseBootclasspathConflict(Dova.JDK.com.sun.tools.javac.main.Option arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[292], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error RepeatedProvidesForService(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[293], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ServiceDefinitionIsEnum(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[294], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ServiceImplementationDoesntHaveANoArgsConstructor(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[295], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ServiceImplementationIsAbstract(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[296], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ServiceImplementationIsInner(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[297], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ServiceImplementationNoArgsConstructorNotPublic(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[298], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error ServiceImplementationNotInRightModule(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[299], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error SourceCantOverwriteInputFile(Dova.JDK.javax.tools.JavaFileObject arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[300], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error StackSimError(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[301], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Set;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error TooManyPatchedModules(Dova.JDK.java.util.Set arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[302], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error TryWithResourcesExprEffectivelyFinalVar(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[303], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/net/URL;Ljava/net/URL;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error TwoClassLoaders2(Dova.JDK.java.net.URL arg0, Dova.JDK.java.net.URL arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[304], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error TypeFoundReq(Dova.JDK.java.lang.Object arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[305], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error TypeFoundReq(Dova.JDK.java.lang.Object arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[306], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error TypesIncompatible(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[307], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error UnmatchedQuote(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[308], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error UnreportedExceptionDefaultConstructor(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[309], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error UnreportedExceptionImplicitClose(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[310], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error UnreportedExceptionNeedToCatchOrThrow(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[311], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error UnsupportedReleaseVersion(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[312], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error VarMightAlreadyBeAssigned(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[313], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error VarMightBeAssignedInLoop(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[314], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error VarMightNotHaveBeenInitialized(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[315], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error VarNotInitializedInDefaultConstructor(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[316], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error VarargsInvalidTrustmeAnno(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[317], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error VarargsInvalidTrustmeAnno(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[318], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/JCDiagnostic$Error;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error DuplicateAnnotationMissingContainer(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[319], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error>(ret);
		}
	}
}
