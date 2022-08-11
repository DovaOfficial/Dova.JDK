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

namespace Dova.JDK.com.sun.tools.javap;

[JniSignatureAttribute("Lcom/sun/tools/javap/AttributeWriter;", "public")]
public partial class AttributeWriter
	: Dova.JDK.com.sun.tools.javap.BasicWriter
	, Dova.JDK.com.sun.tools.classfile.Attribute.Visitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AttributeWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javap/AttributeWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "format", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationWriter", "Lcom/sun/tools/javap/AnnotationWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "codeWriter", "Lcom/sun/tools/javap/CodeWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constantWriter", "Lcom/sun/tools/javap/ConstantWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "options", "Lcom/sun/tools/javap/Options;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constant_pool", "Lcom/sun/tools/classfile/ConstantPool;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "owner", "Ljava/lang/Object;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javap/Context;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "(Lcom/sun/tools/classfile/Descriptor;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljava/lang/Object;Lcom/sun/tools/classfile/Attributes;Lcom/sun/tools/classfile/ConstantPool;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljava/lang/Object;Lcom/sun/tools/classfile/Attribute;Lcom/sun/tools/classfile/ConstantPool;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSignature", "(Lcom/sun/tools/classfile/Signature_attribute;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModuleName", "(Lcom/sun/tools/classfile/ModuleHashes_attribute$Entry;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodName", "(Lcom/sun/tools/classfile/EnclosingMethod_attribute;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instance", "(Lcom/sun/tools/javap/Context;)Lcom/sun/tools/javap/AttributeWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCode", "(Lcom/sun/tools/classfile/Code_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCode", "(Lcom/sun/tools/classfile/Code_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotationDefault", "(Lcom/sun/tools/classfile/AnnotationDefault_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotationDefault", "(Lcom/sun/tools/classfile/AnnotationDefault_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNestHost", "(Lcom/sun/tools/classfile/NestHost_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNestHost", "(Lcom/sun/tools/classfile/NestHost_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModule", "(Lcom/sun/tools/classfile/Module_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModule", "(Lcom/sun/tools/classfile/Module_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModuleResolution", "(Lcom/sun/tools/classfile/ModuleResolution_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModuleResolution", "(Lcom/sun/tools/classfile/ModuleResolution_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModuleTarget", "(Lcom/sun/tools/classfile/ModuleTarget_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModuleTarget", "(Lcom/sun/tools/classfile/ModuleTarget_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaName", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModulePackages", "(Lcom/sun/tools/classfile/ModulePackages_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModulePackages", "(Lcom/sun/tools/classfile/ModulePackages_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRecord", "(Lcom/sun/tools/classfile/Record_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRecord", "(Lcom/sun/tools/classfile/Record_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInnerClasses", "(Lcom/sun/tools/classfile/InnerClasses_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInnerClasses", "(Lcom/sun/tools/classfile/InnerClasses_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRuntimeInvisibleParameterAnnotations", "(Lcom/sun/tools/classfile/RuntimeInvisibleParameterAnnotations_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRuntimeInvisibleParameterAnnotations", "(Lcom/sun/tools/classfile/RuntimeInvisibleParameterAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSourceFile", "(Lcom/sun/tools/classfile/SourceFile_attribute;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaClassName", "(Lcom/sun/tools/classfile/EnclosingMethod_attribute;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaClassName", "(Lcom/sun/tools/classfile/ModuleMainClass_attribute;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaException", "(Lcom/sun/tools/classfile/Exceptions_attribute;I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeInnerClassHeader", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInnerName", "(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/InnerClasses_attribute$Info;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printRequiresTable", "(Lcom/sun/tools/classfile/Module_attribute;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printExportsTable", "(Lcom/sun/tools/classfile/Module_attribute;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printOpensTable", "(Lcom/sun/tools/classfile/Module_attribute;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printUsesTable", "(Lcom/sun/tools/classfile/Module_attribute;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printProvidesTable", "(Lcom/sun/tools/classfile/Module_attribute;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printExportOpenEntry", "(II[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaPackage", "(Lcom/sun/tools/classfile/ModulePackages_attribute;I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetPlatform", "(Lcom/sun/tools/classfile/ModuleTarget_attribute;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFieldType", "(Lcom/sun/tools/classfile/Descriptor;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParameterAnnotations", "(Ljava/lang/String;Lcom/sun/tools/classfile/RuntimeParameterAnnotations_attribute;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSynthetic", "(Lcom/sun/tools/classfile/Synthetic_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSynthetic", "(Lcom/sun/tools/classfile/Synthetic_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitStackMapTable", "(Lcom/sun/tools/classfile/StackMapTable_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitStackMapTable", "(Lcom/sun/tools/classfile/StackMapTable_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitStackMap", "(Lcom/sun/tools/classfile/StackMap_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitStackMap", "(Lcom/sun/tools/classfile/StackMap_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSourceID", "(Lcom/sun/tools/classfile/SourceID_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSourceID", "(Lcom/sun/tools/classfile/SourceID_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSourceFile", "(Lcom/sun/tools/classfile/SourceFile_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSourceFile", "(Lcom/sun/tools/classfile/SourceFile_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSourceDebugExtension", "(Lcom/sun/tools/classfile/SourceDebugExtension_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSourceDebugExtension", "(Lcom/sun/tools/classfile/SourceDebugExtension_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSignature", "(Lcom/sun/tools/classfile/Signature_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSignature", "(Lcom/sun/tools/classfile/Signature_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPermittedSubclasses", "(Lcom/sun/tools/classfile/PermittedSubclasses_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPermittedSubclasses", "(Lcom/sun/tools/classfile/PermittedSubclasses_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRuntimeInvisibleTypeAnnotations", "(Lcom/sun/tools/classfile/RuntimeInvisibleTypeAnnotations_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRuntimeInvisibleTypeAnnotations", "(Lcom/sun/tools/classfile/RuntimeInvisibleTypeAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRuntimeVisibleTypeAnnotations", "(Lcom/sun/tools/classfile/RuntimeVisibleTypeAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRuntimeVisibleTypeAnnotations", "(Lcom/sun/tools/classfile/RuntimeVisibleTypeAnnotations_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRuntimeVisibleParameterAnnotations", "(Lcom/sun/tools/classfile/RuntimeVisibleParameterAnnotations_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRuntimeVisibleParameterAnnotations", "(Lcom/sun/tools/classfile/RuntimeVisibleParameterAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRuntimeInvisibleAnnotations", "(Lcom/sun/tools/classfile/RuntimeInvisibleAnnotations_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRuntimeInvisibleAnnotations", "(Lcom/sun/tools/classfile/RuntimeInvisibleAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRuntimeVisibleAnnotations", "(Lcom/sun/tools/classfile/RuntimeVisibleAnnotations_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRuntimeVisibleAnnotations", "(Lcom/sun/tools/classfile/RuntimeVisibleAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNestMembers", "(Lcom/sun/tools/classfile/NestMembers_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNestMembers", "(Lcom/sun/tools/classfile/NestMembers_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModuleMainClass", "(Lcom/sun/tools/classfile/ModuleMainClass_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModuleMainClass", "(Lcom/sun/tools/classfile/ModuleMainClass_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModuleHashes", "(Lcom/sun/tools/classfile/ModuleHashes_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModuleHashes", "(Lcom/sun/tools/classfile/ModuleHashes_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodParameters", "(Lcom/sun/tools/classfile/MethodParameters_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodParameters", "(Lcom/sun/tools/classfile/MethodParameters_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLocalVariableTypeTable", "(Lcom/sun/tools/classfile/LocalVariableTypeTable_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLocalVariableTypeTable", "(Lcom/sun/tools/classfile/LocalVariableTypeTable_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLocalVariableTable", "(Lcom/sun/tools/classfile/LocalVariableTable_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLocalVariableTable", "(Lcom/sun/tools/classfile/LocalVariableTable_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLineNumberTable", "(Lcom/sun/tools/classfile/LineNumberTable_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLineNumberTable", "(Lcom/sun/tools/classfile/LineNumberTable_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitExceptions", "(Lcom/sun/tools/classfile/Exceptions_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitExceptions", "(Lcom/sun/tools/classfile/Exceptions_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnclosingMethod", "(Lcom/sun/tools/classfile/EnclosingMethod_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnclosingMethod", "(Lcom/sun/tools/classfile/EnclosingMethod_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantValue", "(Lcom/sun/tools/classfile/ConstantValue_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantValue", "(Lcom/sun/tools/classfile/ConstantValue_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCompilationID", "(Lcom/sun/tools/classfile/CompilationID_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCompilationID", "(Lcom/sun/tools/classfile/CompilationID_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCharacterRangeTable", "(Lcom/sun/tools/classfile/CharacterRangeTable_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCharacterRangeTable", "(Lcom/sun/tools/classfile/CharacterRangeTable_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDefault", "(Lcom/sun/tools/classfile/DefaultAttribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDefault", "(Lcom/sun/tools/classfile/DefaultAttribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBootstrapMethods", "(Lcom/sun/tools/classfile/BootstrapMethods_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBootstrapMethods", "(Lcom/sun/tools/classfile/BootstrapMethods_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeList", "(Ljava/lang/String;Ljava/util/Collection;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeModifiers", "(Ljava/util/Collection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toHex", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toHex", "([B)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toHex", "(II)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toHex", "(BI)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDeprecated", "(Lcom/sun/tools/classfile/Deprecated_attribute;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDeprecated", "(Lcom/sun/tools/classfile/Deprecated_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAlgorithm", "(Lcom/sun/tools/classfile/ModuleHashes_attribute;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String format_Property
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

	[JniSignatureAttribute("Lcom/sun/tools/javap/AnnotationWriter;", "private final")]
	public Dova.JDK.com.sun.tools.javap.AnnotationWriter annotationWriter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javap.AnnotationWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javap/CodeWriter;", "private final")]
	public Dova.JDK.com.sun.tools.javap.CodeWriter codeWriter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javap.CodeWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javap/ConstantWriter;", "private final")]
	public Dova.JDK.com.sun.tools.javap.ConstantWriter constantWriter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javap.ConstantWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javap/Options;", "private final")]
	public Dova.JDK.com.sun.tools.javap.Options options_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javap.Options>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool;", "private")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool constant_pool_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object owner_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AttributeWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javap/Context;)V", "protected")]
	public AttributeWriter(Dova.JDK.com.sun.tools.javap.Context arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javap/AttributeWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Descriptor;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getValue(Dova.JDK.com.sun.tools.classfile.Descriptor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Lcom/sun/tools/classfile/Attributes;Lcom/sun/tools/classfile/ConstantPool;)V", "public")]
	public void write(Dova.JDK.java.lang.Object arg0, Dova.JDK.com.sun.tools.classfile.Attributes arg1, Dova.JDK.com.sun.tools.classfile.ConstantPool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Lcom/sun/tools/classfile/Attribute;Lcom/sun/tools/classfile/ConstantPool;)V", "public")]
	public void write(Dova.JDK.java.lang.Object arg0, Dova.JDK.com.sun.tools.classfile.Attribute arg1, Dova.JDK.com.sun.tools.classfile.ConstantPool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Signature_attribute;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getSignature(Dova.JDK.com.sun.tools.classfile.Signature_attribute arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModuleHashes_attribute$Entry;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getModuleName(Dova.JDK.com.sun.tools.classfile.ModuleHashes_attribute.Entry arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/EnclosingMethod_attribute;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getMethodName(Dova.JDK.com.sun.tools.classfile.EnclosingMethod_attribute arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javap/Context;)Lcom/sun/tools/javap/AttributeWriter;", "public static")]
	public static Dova.JDK.com.sun.tools.javap.AttributeWriter instance(Dova.JDK.com.sun.tools.javap.Context arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javap.AttributeWriter>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Code_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitCode(Dova.JDK.com.sun.tools.classfile.Code_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Code_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitCode(Dova.JDK.com.sun.tools.classfile.Code_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/AnnotationDefault_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitAnnotationDefault(Dova.JDK.com.sun.tools.classfile.AnnotationDefault_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/AnnotationDefault_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitAnnotationDefault(Dova.JDK.com.sun.tools.classfile.AnnotationDefault_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/NestHost_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitNestHost(Dova.JDK.com.sun.tools.classfile.NestHost_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/NestHost_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitNestHost(Dova.JDK.com.sun.tools.classfile.NestHost_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Module_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitModule(Dova.JDK.com.sun.tools.classfile.Module_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Module_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitModule(Dova.JDK.com.sun.tools.classfile.Module_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModuleResolution_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitModuleResolution(Dova.JDK.com.sun.tools.classfile.ModuleResolution_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModuleResolution_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitModuleResolution(Dova.JDK.com.sun.tools.classfile.ModuleResolution_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModuleTarget_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitModuleTarget(Dova.JDK.com.sun.tools.classfile.ModuleTarget_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModuleTarget_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitModuleTarget(Dova.JDK.com.sun.tools.classfile.ModuleTarget_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String getJavaName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModulePackages_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitModulePackages(Dova.JDK.com.sun.tools.classfile.ModulePackages_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModulePackages_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitModulePackages(Dova.JDK.com.sun.tools.classfile.ModulePackages_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Record_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitRecord(Dova.JDK.com.sun.tools.classfile.Record_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Record_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitRecord(Dova.JDK.com.sun.tools.classfile.Record_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/InnerClasses_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitInnerClasses(Dova.JDK.com.sun.tools.classfile.InnerClasses_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/InnerClasses_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitInnerClasses(Dova.JDK.com.sun.tools.classfile.InnerClasses_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeInvisibleParameterAnnotations_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitRuntimeInvisibleParameterAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeInvisibleParameterAnnotations_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeInvisibleParameterAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitRuntimeInvisibleParameterAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeInvisibleParameterAnnotations_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/SourceFile_attribute;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getSourceFile(Dova.JDK.com.sun.tools.classfile.SourceFile_attribute arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/EnclosingMethod_attribute;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getJavaClassName(Dova.JDK.com.sun.tools.classfile.EnclosingMethod_attribute arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModuleMainClass_attribute;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getJavaClassName(Dova.JDK.com.sun.tools.classfile.ModuleMainClass_attribute arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Exceptions_attribute;I)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getJavaException(Dova.JDK.com.sun.tools.classfile.Exceptions_attribute arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void writeInnerClassHeader()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32]);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/InnerClasses_attribute$Info;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getInnerName(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, Dova.JDK.com.sun.tools.classfile.InnerClasses_attribute.Info arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Module_attribute;)V", "protected")]
	public void printRequiresTable(Dova.JDK.com.sun.tools.classfile.Module_attribute arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Module_attribute;)V", "protected")]
	public void printExportsTable(Dova.JDK.com.sun.tools.classfile.Module_attribute arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Module_attribute;)V", "protected")]
	public void printOpensTable(Dova.JDK.com.sun.tools.classfile.Module_attribute arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Module_attribute;)V", "protected")]
	public void printUsesTable(Dova.JDK.com.sun.tools.classfile.Module_attribute arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Module_attribute;)V", "protected")]
	public void printProvidesTable(Dova.JDK.com.sun.tools.classfile.Module_attribute arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("(II[I)V", "protected")]
	public void printExportOpenEntry(int arg0, int arg1, JavaArray<int> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModulePackages_attribute;I)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getJavaPackage(Dova.JDK.com.sun.tools.classfile.ModulePackages_attribute arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModuleTarget_attribute;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getTargetPlatform(Dova.JDK.com.sun.tools.classfile.ModuleTarget_attribute arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Descriptor;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getJavaFieldType(Dova.JDK.com.sun.tools.classfile.Descriptor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/classfile/RuntimeParameterAnnotations_attribute;)V", "private")]
	public void visitParameterAnnotations(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.classfile.RuntimeParameterAnnotations_attribute arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Synthetic_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitSynthetic(Dova.JDK.com.sun.tools.classfile.Synthetic_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Synthetic_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitSynthetic(Dova.JDK.com.sun.tools.classfile.Synthetic_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitStackMapTable(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitStackMapTable(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMap_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitStackMap(Dova.JDK.com.sun.tools.classfile.StackMap_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMap_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitStackMap(Dova.JDK.com.sun.tools.classfile.StackMap_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/SourceID_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitSourceID(Dova.JDK.com.sun.tools.classfile.SourceID_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/SourceID_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitSourceID(Dova.JDK.com.sun.tools.classfile.SourceID_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/SourceFile_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitSourceFile(Dova.JDK.com.sun.tools.classfile.SourceFile_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/SourceFile_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitSourceFile(Dova.JDK.com.sun.tools.classfile.SourceFile_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/SourceDebugExtension_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitSourceDebugExtension(Dova.JDK.com.sun.tools.classfile.SourceDebugExtension_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/SourceDebugExtension_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitSourceDebugExtension(Dova.JDK.com.sun.tools.classfile.SourceDebugExtension_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Signature_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitSignature(Dova.JDK.com.sun.tools.classfile.Signature_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Signature_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitSignature(Dova.JDK.com.sun.tools.classfile.Signature_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/PermittedSubclasses_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitPermittedSubclasses(Dova.JDK.com.sun.tools.classfile.PermittedSubclasses_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/PermittedSubclasses_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitPermittedSubclasses(Dova.JDK.com.sun.tools.classfile.PermittedSubclasses_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeInvisibleTypeAnnotations_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitRuntimeInvisibleTypeAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeInvisibleTypeAnnotations_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeInvisibleTypeAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitRuntimeInvisibleTypeAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeInvisibleTypeAnnotations_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeVisibleTypeAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitRuntimeVisibleTypeAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeVisibleTypeAnnotations_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeVisibleTypeAnnotations_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitRuntimeVisibleTypeAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeVisibleTypeAnnotations_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeVisibleParameterAnnotations_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitRuntimeVisibleParameterAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeVisibleParameterAnnotations_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeVisibleParameterAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitRuntimeVisibleParameterAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeVisibleParameterAnnotations_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeInvisibleAnnotations_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitRuntimeInvisibleAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeInvisibleAnnotations_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeInvisibleAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitRuntimeInvisibleAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeInvisibleAnnotations_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeVisibleAnnotations_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitRuntimeVisibleAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeVisibleAnnotations_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeVisibleAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitRuntimeVisibleAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeVisibleAnnotations_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/NestMembers_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitNestMembers(Dova.JDK.com.sun.tools.classfile.NestMembers_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/NestMembers_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitNestMembers(Dova.JDK.com.sun.tools.classfile.NestMembers_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModuleMainClass_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitModuleMainClass(Dova.JDK.com.sun.tools.classfile.ModuleMainClass_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[72], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModuleMainClass_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitModuleMainClass(Dova.JDK.com.sun.tools.classfile.ModuleMainClass_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModuleHashes_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitModuleHashes(Dova.JDK.com.sun.tools.classfile.ModuleHashes_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[74], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModuleHashes_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitModuleHashes(Dova.JDK.com.sun.tools.classfile.ModuleHashes_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/MethodParameters_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitMethodParameters(Dova.JDK.com.sun.tools.classfile.MethodParameters_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/MethodParameters_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitMethodParameters(Dova.JDK.com.sun.tools.classfile.MethodParameters_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/LocalVariableTypeTable_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitLocalVariableTypeTable(Dova.JDK.com.sun.tools.classfile.LocalVariableTypeTable_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/LocalVariableTypeTable_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitLocalVariableTypeTable(Dova.JDK.com.sun.tools.classfile.LocalVariableTypeTable_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[79], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/LocalVariableTable_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitLocalVariableTable(Dova.JDK.com.sun.tools.classfile.LocalVariableTable_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[80], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/LocalVariableTable_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitLocalVariableTable(Dova.JDK.com.sun.tools.classfile.LocalVariableTable_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[81], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/LineNumberTable_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitLineNumberTable(Dova.JDK.com.sun.tools.classfile.LineNumberTable_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[82], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/LineNumberTable_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitLineNumberTable(Dova.JDK.com.sun.tools.classfile.LineNumberTable_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[83], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Exceptions_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitExceptions(Dova.JDK.com.sun.tools.classfile.Exceptions_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[84], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Exceptions_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitExceptions(Dova.JDK.com.sun.tools.classfile.Exceptions_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[85], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/EnclosingMethod_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitEnclosingMethod(Dova.JDK.com.sun.tools.classfile.EnclosingMethod_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[86], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/EnclosingMethod_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitEnclosingMethod(Dova.JDK.com.sun.tools.classfile.EnclosingMethod_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[87], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantValue_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitConstantValue(Dova.JDK.com.sun.tools.classfile.ConstantValue_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[88], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantValue_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitConstantValue(Dova.JDK.com.sun.tools.classfile.ConstantValue_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[89], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/CompilationID_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitCompilationID(Dova.JDK.com.sun.tools.classfile.CompilationID_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[90], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/CompilationID_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitCompilationID(Dova.JDK.com.sun.tools.classfile.CompilationID_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[91], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/CharacterRangeTable_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitCharacterRangeTable(Dova.JDK.com.sun.tools.classfile.CharacterRangeTable_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[92], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/CharacterRangeTable_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitCharacterRangeTable(Dova.JDK.com.sun.tools.classfile.CharacterRangeTable_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[93], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/DefaultAttribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitDefault(Dova.JDK.com.sun.tools.classfile.DefaultAttribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[94], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/DefaultAttribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitDefault(Dova.JDK.com.sun.tools.classfile.DefaultAttribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[95], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/BootstrapMethods_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitBootstrapMethods(Dova.JDK.com.sun.tools.classfile.BootstrapMethods_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[96], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/BootstrapMethods_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitBootstrapMethods(Dova.JDK.com.sun.tools.classfile.BootstrapMethods_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[97], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Collection;Ljava/lang/String;)V", "")]
	public void writeList(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Collection arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[98], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)V", "")]
	public void writeModifiers(Dova.JDK.java.util.Collection arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[99], arg0);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String toHex(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[100], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([B)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String toHex(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[101], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String toHex(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[102], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(BI)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String toHex(byte arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[103], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Deprecated_attribute;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitDeprecated(Dova.JDK.com.sun.tools.classfile.Deprecated_attribute arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[104], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Deprecated_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitDeprecated(Dova.JDK.com.sun.tools.classfile.Deprecated_attribute arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[105], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModuleHashes_attribute;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getAlgorithm(Dova.JDK.com.sun.tools.classfile.ModuleHashes_attribute arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[106], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javap/AttributeWriter$StackMapTableWriter;", "")]
	public partial class StackMapTableWriter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.stack_map_frame.Visitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StackMapTableWriter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javap/AttributeWriter$StackMapTableWriter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javap/AttributeWriter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javap/AttributeWriter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/classfile/StackMapTable_attribute$stack_map_frame;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printHeader", "(Lcom/sun/tools/classfile/StackMapTable_attribute$stack_map_frame;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_full_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$full_frame;Ljava/lang/Void;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_full_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$full_frame;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printMap", "(Ljava/lang/String;[Lcom/sun/tools/classfile/StackMapTable_attribute$verification_type_info;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapTypeName", "(I)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_same_locals_1_stack_item_frame_extended", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame_extended;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_same_locals_1_stack_item_frame_extended", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame_extended;Ljava/lang/Void;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_chop_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$chop_frame;Ljava/lang/Void;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_chop_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$chop_frame;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_same_frame_extended", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame_extended;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_same_frame_extended", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame_extended;Ljava/lang/Void;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_append_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$append_frame;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_append_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$append_frame;Ljava/lang/Void;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_same_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_same_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame;Ljava/lang/Void;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_same_locals_1_stack_item_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame;Ljava/lang/Void;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit_same_locals_1_stack_item_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame;Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javap/AttributeWriter;", "final")]
		public Dova.JDK.com.sun.tools.javap.AttributeWriter this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javap.AttributeWriter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StackMapTableWriter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javap/AttributeWriter;)V", "")]
		public StackMapTableWriter(Dova.JDK.com.sun.tools.javap.AttributeWriter arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javap/AttributeWriter$StackMapTableWriter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$stack_map_frame;)V", "public")]
		public void write(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.stack_map_frame arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$stack_map_frame;Ljava/lang/String;)V", "")]
		public void printHeader(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.stack_map_frame arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$full_frame;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visit_full_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.full_frame arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$full_frame;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visit_full_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.full_frame arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Lcom/sun/tools/classfile/StackMapTable_attribute$verification_type_info;)V", "")]
		public void printMap(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.verification_type_info> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(I)Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String mapTypeName(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame_extended;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visit_same_locals_1_stack_item_frame_extended(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_locals_1_stack_item_frame_extended arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame_extended;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visit_same_locals_1_stack_item_frame_extended(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_locals_1_stack_item_frame_extended arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$chop_frame;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visit_chop_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.chop_frame arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$chop_frame;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visit_chop_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.chop_frame arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame_extended;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visit_same_frame_extended(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_frame_extended arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame_extended;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visit_same_frame_extended(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_frame_extended arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$append_frame;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visit_append_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.append_frame arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$append_frame;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visit_append_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.append_frame arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visit_same_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_frame arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visit_same_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_frame arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visit_same_locals_1_stack_item_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_locals_1_stack_item_frame arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visit_same_locals_1_stack_item_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_locals_1_stack_item_frame arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
