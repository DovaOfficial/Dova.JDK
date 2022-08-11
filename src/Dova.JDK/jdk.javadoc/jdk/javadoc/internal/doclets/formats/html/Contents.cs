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

namespace Dova.JDK.jdk.javadoc.@internal.doclets.formats.html;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/Contents;", "public")]
public partial class Contents
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Contents()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/formats/html/Contents;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allClassesAndInterfacesLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allImplementedInterfacesLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allModulesLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allPackagesLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allSuperinterfacesLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "also", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTypeOptionalMemberLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTypeRequiredMemberLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotateTypeOptionalMemberSummaryLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotateTypeRequiredMemberSummaryLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationType", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTypeDetailsLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTypeMemberDetail", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationtypes", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTypes", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classes", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constantFieldLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constantsSummaryTitle", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constructorLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constructorDetailsLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constructorSummaryLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constructors", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contentsHeading", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultPackageLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "default_", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "deprecatedAPI", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "deprecatedLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "deprecatedPhrase", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "deprecatedForRemovalPhrase", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptionFromClassLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptionFromInterfaceLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptionLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "detailLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enclosingClassLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enclosingInterfaceLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enumConstantLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enumConstantDetailLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enumConstantSummary", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enum_", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enums", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exceptionClass", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exceptionClasses", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exportedTo", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDetailsLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldSummaryLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fields", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fromLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "functionalInterface", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "functionalInterfaceMessage", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "helpLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "helpSubNavLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hierarchyForAllPackages", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementation", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementingClassesLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inClass", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inInterface", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "indexLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interfaceLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interfaces", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDetailLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodSummary", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methods", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modifierAndTypeLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modifierLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "moduleLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "module_", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "moduleSubNavLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modulesLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "navAnnotationTypeMember", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "navAnnotationTypeOptionalMember", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "navAnnotationTypeRequiredMember", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "navClassesAndInterfaces", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "navConstructor", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "navDescription", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "navEnum", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "navField", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "navHelpNavigation", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "navHelpPages", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "navMethod", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "navModules", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "navNested", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "navPackages", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "navProperty", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "navServices", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nestedClassSummary", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "newAPI", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "newLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "noScriptMessage", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "openModuleLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "openedTo", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "overridesLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "overviewLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "packageHierarchies", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "packageLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "package_", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "packagesLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "packageSubNavLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "packageSummaryLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameters", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "previewAPI", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "previewLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "previewMark", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "previewPhrase", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "properties", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "propertyLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "propertyDetailsLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "propertySummaryLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "records", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponents", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "referencedIn", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "relatedPackages", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returns", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "seeAlso", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serializedForm", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "servicesLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "specifiedByLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subclassesLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subinterfacesLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "summaryLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "systemPropertiesLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "systemPropertiesSummaryLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "throws_", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "treeLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeParameters", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "useLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "valueLabel", "Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "navLinkLabels", "Ljava/util/EnumMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resources", "Ljdk/javadoc/internal/doclets/toolkit/Resources;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "join", "(Ljdk/javadoc/internal/doclets/toolkit/Content;Ljava/util/Collection;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContent", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContent", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContent", "(Ljava/lang/String;Ljava/lang/Object;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContent", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNavLinkLabelContent", "(Ljdk/javadoc/internal/doclets/toolkit/util/VisibleMemberTable$Kind;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNonBreakResource", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNonBreakString", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content allClassesAndInterfacesLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content allImplementedInterfacesLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content allModulesLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content allPackagesLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content allSuperinterfacesLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content also_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content annotationTypeOptionalMemberLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content annotationTypeRequiredMemberLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content annotateTypeOptionalMemberSummaryLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content annotateTypeRequiredMemberSummaryLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content annotationType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content annotationTypeDetailsLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content annotationTypeMemberDetail_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content annotationtypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content annotationTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content classLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content classes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content constantFieldLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content constantsSummaryTitle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content constructorLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content constructorDetailsLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content constructorSummaryLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content constructors_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content contentsHeading_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content defaultPackageLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content default__Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content deprecatedAPI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content deprecatedLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content deprecatedPhrase_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content deprecatedForRemovalPhrase_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content descriptionFromClassLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content descriptionFromInterfaceLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content descriptionLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content detailLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content enclosingClassLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content enclosingInterfaceLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content enumConstantLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content enumConstantDetailLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content enumConstantSummary_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content enum__Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content enums_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content exceptionClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content exceptionClasses_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content exportedTo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content fieldLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[44]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content fieldDetailsLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[45]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content fieldSummaryLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[46]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content fields_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[47]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content fromLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[48]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content functionalInterface_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[49]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[49], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content functionalInterfaceMessage_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[50]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[50], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content helpLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[51]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[51], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content helpSubNavLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[52]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[52], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content hierarchyForAllPackages_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[53]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[53], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content implementation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[54]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[54], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content implementingClassesLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[55]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[55], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content inClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[56]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[56], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content inInterface_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[57]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[57], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content indexLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[58]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[58], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content interfaceLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[59]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[59], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content interfaces_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[60]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[60], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content methodDetailLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[61]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[61], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content methodLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[62]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[62], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content methodSummary_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[63]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[63], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content methods_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[64]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[64], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content modifierAndTypeLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[65]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[65], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content modifierLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[66]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[66], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content moduleLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[67]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[67], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content module__Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[68]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[68], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content moduleSubNavLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[69]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[69], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content modulesLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[70]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[70], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content navAnnotationTypeMember_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[71]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[71], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content navAnnotationTypeOptionalMember_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[72]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[72], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content navAnnotationTypeRequiredMember_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[73]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[73], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content navClassesAndInterfaces_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[74]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[74], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content navConstructor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[75]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[75], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content navDescription_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[76]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[76], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content navEnum_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[77]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[77], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content navField_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[78]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[78], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content navHelpNavigation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[79]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[79], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content navHelpPages_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[80]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[80], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content navMethod_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[81]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[81], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content navModules_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[82]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[82], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content navNested_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[83]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[83], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content navPackages_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[84]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[84], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content navProperty_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[85]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[85], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content navServices_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[86]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[86], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content nestedClassSummary_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[87]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[87], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content newAPI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[88]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[88], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content newLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[89]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[89], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content noScriptMessage_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[90]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[90], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content openModuleLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[91]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[91], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content openedTo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[92]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[92], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content overridesLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[93]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[93], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content overviewLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[94]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[94], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content packageHierarchies_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[95]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[95], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content packageLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[96]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[96], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content package__Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[97]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[97], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content packagesLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[98]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[98], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content packageSubNavLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[99]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[99], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content packageSummaryLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[100]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[100], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content parameters_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[101]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[101], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content previewAPI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[102]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[102], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content previewLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[103]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[103], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content previewMark_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[104]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[104], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content previewPhrase_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[105]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[105], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content properties_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[106]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[106], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content propertyLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[107]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[107], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content propertyDetailsLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[108]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[108], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content propertySummaryLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[109]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[109], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content records_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[110]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[110], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content recordComponents_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[111]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[111], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content referencedIn_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[112]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[112], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content relatedPackages_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[113]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[113], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content returns_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[114]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[114], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content seeAlso_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[115]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[115], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content serializedForm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[116]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[116], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content servicesLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[117]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[117], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content specifiedByLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[118]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[118], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content subclassesLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[119]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[119], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content subinterfacesLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[120]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[120], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content summaryLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[121]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[121], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content systemPropertiesLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[122]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[122], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content systemPropertiesSummaryLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[123]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[123], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content throws__Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[124]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[124], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content treeLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[125]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[125], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content typeLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[126]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[126], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content typeParameters_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[127]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[127], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content useLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[128]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[128], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Content;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content valueLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[129]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[129], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/EnumMap;", "private final")]
	public Dova.JDK.java.util.EnumMap navLinkLabels_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[130]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[130], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/Resources;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Resources resources_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[131]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Resources>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[131], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Contents(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;)V", "")]
	public Contents(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/formats/html/Contents;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;Ljava/util/Collection;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content join(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0, Dova.JDK.java.util.Collection arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getContent(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getContent(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getContent(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getContent(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/VisibleMemberTable$Kind;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getNavLinkLabelContent(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.VisibleMemberTable.Kind arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getNonBreakResource(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getNonBreakString(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}
}
