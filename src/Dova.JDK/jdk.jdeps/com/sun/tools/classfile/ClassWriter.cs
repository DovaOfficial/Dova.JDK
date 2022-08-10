/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.tools.classfile;

[JniSignatureAttribute("Lcom/sun/tools/classfile/ClassWriter;", "public")]
public partial class ClassWriter
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/ClassWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "classFile", "Lcom/sun/tools/classfile/ClassFile;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "out", "Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "attributeWriter", "Lcom/sun/tools/classfile/ClassWriter$AttributeWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "constantPoolWriter", "Lcom/sun/tools/classfile/ClassWriter$ConstantPoolWriter;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ClassWriter", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "write", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "write", "(Lcom/sun/tools/classfile/ClassFile;Ljava/io/OutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "write", "(Lcom/sun/tools/classfile/ClassFile;Ljava/io/File;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeFields", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeHeader", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeClassInfo", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeAccessFlags", "(Lcom/sun/tools/classfile/AccessFlags;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeConstantPool", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeMethods", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeField", "(Lcom/sun/tools/classfile/Field;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeMethod", "(Lcom/sun/tools/classfile/Method;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeDescriptor", "(Lcom/sun/tools/classfile/Descriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeAttributes", "(Lcom/sun/tools/classfile/Attributes;)V"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ClassFile;", "protected")]
	public Dova.JDK.com.sun.tools.classfile.ClassFile classFile_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassFile>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;", "protected")]
	public Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream @out_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ClassWriter$AttributeWriter;", "protected")]
	public Dova.JDK.com.sun.tools.classfile.ClassWriter.AttributeWriter attributeWriter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassWriter.AttributeWriter>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ClassWriter$ConstantPoolWriter;", "protected")]
	public Dova.JDK.com.sun.tools.classfile.ClassWriter.ConstantPoolWriter constantPoolWriter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassWriter.ConstantPoolWriter>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ClassWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ClassWriter() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ClassWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "protected")]
	public void write()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;Ljava/io/OutputStream;)V", "public")]
	public void write(Dova.JDK.com.sun.tools.classfile.ClassFile arg0, Dova.JDK.java.io.OutputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;Ljava/io/File;)V", "public")]
	public void write(Dova.JDK.com.sun.tools.classfile.ClassFile arg0, Dova.JDK.java.io.File arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void writeFields()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void writeHeader()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void writeClassInfo()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/AccessFlags;)V", "protected")]
	public void writeAccessFlags(Dova.JDK.com.sun.tools.classfile.AccessFlags arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void writeConstantPool()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void writeMethods()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Field;)V", "protected")]
	public void writeField(Dova.JDK.com.sun.tools.classfile.Field arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Method;)V", "protected")]
	public void writeMethod(Dova.JDK.com.sun.tools.classfile.Method arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Descriptor;)V", "protected")]
	public void writeDescriptor(Dova.JDK.com.sun.tools.classfile.Descriptor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Attributes;)V", "protected")]
	public void writeAttributes(Dova.JDK.com.sun.tools.classfile.Attributes arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ClassWriter$AttributeWriter;", "protected static")]
	public partial class AttributeWriter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.classfile.Attribute.Visitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AttributeWriter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/ClassWriter$AttributeWriter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "annotationWriter", "Lcom/sun/tools/classfile/ClassWriter$AnnotationWriter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "stackMapWriter", "Lcom/sun/tools/classfile/ClassWriter$StackMapTableWriter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AttributeWriter", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "write", "(Lcom/sun/tools/classfile/Attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "write", "(Lcom/sun/tools/classfile/Attributes;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitCode", "(Lcom/sun/tools/classfile/Code_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitCode", "(Lcom/sun/tools/classfile/Code_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitAnnotationDefault", "(Lcom/sun/tools/classfile/AnnotationDefault_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitAnnotationDefault", "(Lcom/sun/tools/classfile/AnnotationDefault_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitNestHost", "(Lcom/sun/tools/classfile/NestHost_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitNestHost", "(Lcom/sun/tools/classfile/NestHost_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitModule", "(Lcom/sun/tools/classfile/Module_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitModule", "(Lcom/sun/tools/classfile/Module_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitModuleResolution", "(Lcom/sun/tools/classfile/ModuleResolution_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitModuleResolution", "(Lcom/sun/tools/classfile/ModuleResolution_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitModuleTarget", "(Lcom/sun/tools/classfile/ModuleTarget_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitModuleTarget", "(Lcom/sun/tools/classfile/ModuleTarget_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeLocalVariableTypeTableEntry", "(Lcom/sun/tools/classfile/LocalVariableTypeTable_attribute$Entry;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeCharacterRangeTableEntry", "(Lcom/sun/tools/classfile/CharacterRangeTable_attribute$Entry;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeInnerClassesInfo", "(Lcom/sun/tools/classfile/InnerClasses_attribute$Info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeLineNumberTableEntry", "(Lcom/sun/tools/classfile/LineNumberTable_attribute$Entry;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeLocalVariableTableEntry", "(Lcom/sun/tools/classfile/LocalVariableTable_attribute$Entry;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeAccessFlags", "(Lcom/sun/tools/classfile/AccessFlags;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeExceptionTableEntry", "(Lcom/sun/tools/classfile/Code_attribute$Exception_data;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitModulePackages", "(Lcom/sun/tools/classfile/ModulePackages_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitModulePackages", "(Lcom/sun/tools/classfile/ModulePackages_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitRecord", "(Lcom/sun/tools/classfile/Record_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitRecord", "(Lcom/sun/tools/classfile/Record_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitInnerClasses", "(Lcom/sun/tools/classfile/InnerClasses_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitInnerClasses", "(Lcom/sun/tools/classfile/InnerClasses_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitRuntimeInvisibleParameterAnnotations", "(Lcom/sun/tools/classfile/RuntimeInvisibleParameterAnnotations_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitRuntimeInvisibleParameterAnnotations", "(Lcom/sun/tools/classfile/RuntimeInvisibleParameterAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitSynthetic", "(Lcom/sun/tools/classfile/Synthetic_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitSynthetic", "(Lcom/sun/tools/classfile/Synthetic_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitStackMapTable", "(Lcom/sun/tools/classfile/StackMapTable_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitStackMapTable", "(Lcom/sun/tools/classfile/StackMapTable_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitStackMap", "(Lcom/sun/tools/classfile/StackMap_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitStackMap", "(Lcom/sun/tools/classfile/StackMap_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitSourceID", "(Lcom/sun/tools/classfile/SourceID_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitSourceID", "(Lcom/sun/tools/classfile/SourceID_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitSourceFile", "(Lcom/sun/tools/classfile/SourceFile_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitSourceFile", "(Lcom/sun/tools/classfile/SourceFile_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitSourceDebugExtension", "(Lcom/sun/tools/classfile/SourceDebugExtension_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitSourceDebugExtension", "(Lcom/sun/tools/classfile/SourceDebugExtension_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitSignature", "(Lcom/sun/tools/classfile/Signature_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitSignature", "(Lcom/sun/tools/classfile/Signature_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitPermittedSubclasses", "(Lcom/sun/tools/classfile/PermittedSubclasses_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitPermittedSubclasses", "(Lcom/sun/tools/classfile/PermittedSubclasses_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitRuntimeInvisibleTypeAnnotations", "(Lcom/sun/tools/classfile/RuntimeInvisibleTypeAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitRuntimeInvisibleTypeAnnotations", "(Lcom/sun/tools/classfile/RuntimeInvisibleTypeAnnotations_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitRuntimeVisibleTypeAnnotations", "(Lcom/sun/tools/classfile/RuntimeVisibleTypeAnnotations_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitRuntimeVisibleTypeAnnotations", "(Lcom/sun/tools/classfile/RuntimeVisibleTypeAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitRuntimeVisibleParameterAnnotations", "(Lcom/sun/tools/classfile/RuntimeVisibleParameterAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitRuntimeVisibleParameterAnnotations", "(Lcom/sun/tools/classfile/RuntimeVisibleParameterAnnotations_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitRuntimeInvisibleAnnotations", "(Lcom/sun/tools/classfile/RuntimeInvisibleAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitRuntimeInvisibleAnnotations", "(Lcom/sun/tools/classfile/RuntimeInvisibleAnnotations_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitRuntimeVisibleAnnotations", "(Lcom/sun/tools/classfile/RuntimeVisibleAnnotations_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitRuntimeVisibleAnnotations", "(Lcom/sun/tools/classfile/RuntimeVisibleAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitNestMembers", "(Lcom/sun/tools/classfile/NestMembers_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitNestMembers", "(Lcom/sun/tools/classfile/NestMembers_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitModuleMainClass", "(Lcom/sun/tools/classfile/ModuleMainClass_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitModuleMainClass", "(Lcom/sun/tools/classfile/ModuleMainClass_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitModuleHashes", "(Lcom/sun/tools/classfile/ModuleHashes_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitModuleHashes", "(Lcom/sun/tools/classfile/ModuleHashes_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitMethodParameters", "(Lcom/sun/tools/classfile/MethodParameters_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitMethodParameters", "(Lcom/sun/tools/classfile/MethodParameters_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLocalVariableTypeTable", "(Lcom/sun/tools/classfile/LocalVariableTypeTable_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLocalVariableTypeTable", "(Lcom/sun/tools/classfile/LocalVariableTypeTable_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLocalVariableTable", "(Lcom/sun/tools/classfile/LocalVariableTable_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLocalVariableTable", "(Lcom/sun/tools/classfile/LocalVariableTable_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLineNumberTable", "(Lcom/sun/tools/classfile/LineNumberTable_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLineNumberTable", "(Lcom/sun/tools/classfile/LineNumberTable_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitExceptions", "(Lcom/sun/tools/classfile/Exceptions_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitExceptions", "(Lcom/sun/tools/classfile/Exceptions_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitEnclosingMethod", "(Lcom/sun/tools/classfile/EnclosingMethod_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitEnclosingMethod", "(Lcom/sun/tools/classfile/EnclosingMethod_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitConstantValue", "(Lcom/sun/tools/classfile/ConstantValue_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitConstantValue", "(Lcom/sun/tools/classfile/ConstantValue_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitCompilationID", "(Lcom/sun/tools/classfile/CompilationID_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitCompilationID", "(Lcom/sun/tools/classfile/CompilationID_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitCharacterRangeTable", "(Lcom/sun/tools/classfile/CharacterRangeTable_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitCharacterRangeTable", "(Lcom/sun/tools/classfile/CharacterRangeTable_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDefault", "(Lcom/sun/tools/classfile/DefaultAttribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDefault", "(Lcom/sun/tools/classfile/DefaultAttribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitBootstrapMethods", "(Lcom/sun/tools/classfile/BootstrapMethods_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitBootstrapMethods", "(Lcom/sun/tools/classfile/BootstrapMethods_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDeprecated", "(Lcom/sun/tools/classfile/Deprecated_attribute;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDeprecated", "(Lcom/sun/tools/classfile/Deprecated_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/ClassWriter$AnnotationWriter;", "protected")]
		public Dova.JDK.com.sun.tools.classfile.ClassWriter.AnnotationWriter annotationWriter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassWriter.AnnotationWriter>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/ClassWriter$StackMapTableWriter;", "protected")]
		public Dova.JDK.com.sun.tools.classfile.ClassWriter.StackMapTableWriter stackMapWriter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassWriter.StackMapTableWriter>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AttributeWriter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public AttributeWriter() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ClassWriter$AttributeWriter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V", "public")]
		public void write(Dova.JDK.com.sun.tools.classfile.Attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Attributes;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V", "public")]
		public void write(Dova.JDK.com.sun.tools.classfile.Attributes arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Code_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitCode(Dova.JDK.com.sun.tools.classfile.Code_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Code_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitCode(Dova.JDK.com.sun.tools.classfile.Code_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/AnnotationDefault_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitAnnotationDefault(Dova.JDK.com.sun.tools.classfile.AnnotationDefault_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/AnnotationDefault_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitAnnotationDefault(Dova.JDK.com.sun.tools.classfile.AnnotationDefault_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/NestHost_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitNestHost(Dova.JDK.com.sun.tools.classfile.NestHost_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/NestHost_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitNestHost(Dova.JDK.com.sun.tools.classfile.NestHost_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Module_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitModule(Dova.JDK.com.sun.tools.classfile.Module_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Module_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitModule(Dova.JDK.com.sun.tools.classfile.Module_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModuleResolution_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitModuleResolution(Dova.JDK.com.sun.tools.classfile.ModuleResolution_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModuleResolution_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitModuleResolution(Dova.JDK.com.sun.tools.classfile.ModuleResolution_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModuleTarget_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitModuleTarget(Dova.JDK.com.sun.tools.classfile.ModuleTarget_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModuleTarget_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitModuleTarget(Dova.JDK.com.sun.tools.classfile.ModuleTarget_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/LocalVariableTypeTable_attribute$Entry;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V", "protected")]
		public void writeLocalVariableTypeTableEntry(Dova.JDK.com.sun.tools.classfile.LocalVariableTypeTable_attribute.Entry arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/CharacterRangeTable_attribute$Entry;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V", "protected")]
		public void writeCharacterRangeTableEntry(Dova.JDK.com.sun.tools.classfile.CharacterRangeTable_attribute.Entry arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/InnerClasses_attribute$Info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V", "protected")]
		public void writeInnerClassesInfo(Dova.JDK.com.sun.tools.classfile.InnerClasses_attribute.Info arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/LineNumberTable_attribute$Entry;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V", "protected")]
		public void writeLineNumberTableEntry(Dova.JDK.com.sun.tools.classfile.LineNumberTable_attribute.Entry arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/LocalVariableTable_attribute$Entry;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V", "protected")]
		public void writeLocalVariableTableEntry(Dova.JDK.com.sun.tools.classfile.LocalVariableTable_attribute.Entry arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/AccessFlags;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V", "protected")]
		public void writeAccessFlags(Dova.JDK.com.sun.tools.classfile.AccessFlags arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Code_attribute$Exception_data;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V", "protected")]
		public void writeExceptionTableEntry(Dova.JDK.com.sun.tools.classfile.Code_attribute.Exception_data arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModulePackages_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitModulePackages(Dova.JDK.com.sun.tools.classfile.ModulePackages_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModulePackages_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitModulePackages(Dova.JDK.com.sun.tools.classfile.ModulePackages_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Record_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitRecord(Dova.JDK.com.sun.tools.classfile.Record_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Record_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitRecord(Dova.JDK.com.sun.tools.classfile.Record_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/InnerClasses_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitInnerClasses(Dova.JDK.com.sun.tools.classfile.InnerClasses_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/InnerClasses_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitInnerClasses(Dova.JDK.com.sun.tools.classfile.InnerClasses_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeInvisibleParameterAnnotations_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitRuntimeInvisibleParameterAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeInvisibleParameterAnnotations_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeInvisibleParameterAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitRuntimeInvisibleParameterAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeInvisibleParameterAnnotations_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Synthetic_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitSynthetic(Dova.JDK.com.sun.tools.classfile.Synthetic_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Synthetic_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitSynthetic(Dova.JDK.com.sun.tools.classfile.Synthetic_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitStackMapTable(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitStackMapTable(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMap_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitStackMap(Dova.JDK.com.sun.tools.classfile.StackMap_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMap_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitStackMap(Dova.JDK.com.sun.tools.classfile.StackMap_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/SourceID_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitSourceID(Dova.JDK.com.sun.tools.classfile.SourceID_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/SourceID_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitSourceID(Dova.JDK.com.sun.tools.classfile.SourceID_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/SourceFile_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitSourceFile(Dova.JDK.com.sun.tools.classfile.SourceFile_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/SourceFile_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitSourceFile(Dova.JDK.com.sun.tools.classfile.SourceFile_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/SourceDebugExtension_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitSourceDebugExtension(Dova.JDK.com.sun.tools.classfile.SourceDebugExtension_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/SourceDebugExtension_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitSourceDebugExtension(Dova.JDK.com.sun.tools.classfile.SourceDebugExtension_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Signature_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitSignature(Dova.JDK.com.sun.tools.classfile.Signature_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Signature_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitSignature(Dova.JDK.com.sun.tools.classfile.Signature_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/PermittedSubclasses_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitPermittedSubclasses(Dova.JDK.com.sun.tools.classfile.PermittedSubclasses_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/PermittedSubclasses_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitPermittedSubclasses(Dova.JDK.com.sun.tools.classfile.PermittedSubclasses_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeInvisibleTypeAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitRuntimeInvisibleTypeAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeInvisibleTypeAnnotations_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeInvisibleTypeAnnotations_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitRuntimeInvisibleTypeAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeInvisibleTypeAnnotations_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeVisibleTypeAnnotations_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitRuntimeVisibleTypeAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeVisibleTypeAnnotations_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeVisibleTypeAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitRuntimeVisibleTypeAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeVisibleTypeAnnotations_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeVisibleParameterAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitRuntimeVisibleParameterAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeVisibleParameterAnnotations_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeVisibleParameterAnnotations_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitRuntimeVisibleParameterAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeVisibleParameterAnnotations_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeInvisibleAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitRuntimeInvisibleAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeInvisibleAnnotations_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeInvisibleAnnotations_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitRuntimeInvisibleAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeInvisibleAnnotations_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeVisibleAnnotations_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitRuntimeVisibleAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeVisibleAnnotations_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeVisibleAnnotations_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitRuntimeVisibleAnnotations(Dova.JDK.com.sun.tools.classfile.RuntimeVisibleAnnotations_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/NestMembers_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitNestMembers(Dova.JDK.com.sun.tools.classfile.NestMembers_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/NestMembers_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitNestMembers(Dova.JDK.com.sun.tools.classfile.NestMembers_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModuleMainClass_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitModuleMainClass(Dova.JDK.com.sun.tools.classfile.ModuleMainClass_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModuleMainClass_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitModuleMainClass(Dova.JDK.com.sun.tools.classfile.ModuleMainClass_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModuleHashes_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitModuleHashes(Dova.JDK.com.sun.tools.classfile.ModuleHashes_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ModuleHashes_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitModuleHashes(Dova.JDK.com.sun.tools.classfile.ModuleHashes_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/MethodParameters_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitMethodParameters(Dova.JDK.com.sun.tools.classfile.MethodParameters_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/MethodParameters_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitMethodParameters(Dova.JDK.com.sun.tools.classfile.MethodParameters_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/LocalVariableTypeTable_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitLocalVariableTypeTable(Dova.JDK.com.sun.tools.classfile.LocalVariableTypeTable_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/LocalVariableTypeTable_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitLocalVariableTypeTable(Dova.JDK.com.sun.tools.classfile.LocalVariableTypeTable_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/LocalVariableTable_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitLocalVariableTable(Dova.JDK.com.sun.tools.classfile.LocalVariableTable_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/LocalVariableTable_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitLocalVariableTable(Dova.JDK.com.sun.tools.classfile.LocalVariableTable_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/LineNumberTable_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitLineNumberTable(Dova.JDK.com.sun.tools.classfile.LineNumberTable_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/LineNumberTable_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitLineNumberTable(Dova.JDK.com.sun.tools.classfile.LineNumberTable_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Exceptions_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitExceptions(Dova.JDK.com.sun.tools.classfile.Exceptions_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Exceptions_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitExceptions(Dova.JDK.com.sun.tools.classfile.Exceptions_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/EnclosingMethod_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitEnclosingMethod(Dova.JDK.com.sun.tools.classfile.EnclosingMethod_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/EnclosingMethod_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitEnclosingMethod(Dova.JDK.com.sun.tools.classfile.EnclosingMethod_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[72], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantValue_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitConstantValue(Dova.JDK.com.sun.tools.classfile.ConstantValue_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantValue_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitConstantValue(Dova.JDK.com.sun.tools.classfile.ConstantValue_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[74], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/CompilationID_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitCompilationID(Dova.JDK.com.sun.tools.classfile.CompilationID_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/CompilationID_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitCompilationID(Dova.JDK.com.sun.tools.classfile.CompilationID_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/CharacterRangeTable_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitCharacterRangeTable(Dova.JDK.com.sun.tools.classfile.CharacterRangeTable_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/CharacterRangeTable_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitCharacterRangeTable(Dova.JDK.com.sun.tools.classfile.CharacterRangeTable_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/DefaultAttribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitDefault(Dova.JDK.com.sun.tools.classfile.DefaultAttribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[79], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/DefaultAttribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitDefault(Dova.JDK.com.sun.tools.classfile.DefaultAttribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[80], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/BootstrapMethods_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitBootstrapMethods(Dova.JDK.com.sun.tools.classfile.BootstrapMethods_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[81], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/BootstrapMethods_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitBootstrapMethods(Dova.JDK.com.sun.tools.classfile.BootstrapMethods_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[82], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Deprecated_attribute;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitDeprecated(Dova.JDK.com.sun.tools.classfile.Deprecated_attribute arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[83], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Deprecated_attribute;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitDeprecated(Dova.JDK.com.sun.tools.classfile.Deprecated_attribute arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[84], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ClassWriter$ConstantPoolWriter;", "protected static")]
	public partial class ConstantPoolWriter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ConstantPoolWriter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/ClassWriter$ConstantPoolWriter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ConstantPoolWriter", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "write", "(Lcom/sun/tools/classfile/ConstantPool$CPInfo;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitModule", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitModule", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitPackage", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitPackage", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitClass", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitClass", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeRef", "(Lcom/sun/tools/classfile/ConstantPool$CPRefInfo;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitInterfaceMethodref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InterfaceMethodref_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitInterfaceMethodref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InterfaceMethodref_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFieldref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFieldref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDouble", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Double_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDouble", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Double_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLong", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Long_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLong", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Long_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitString", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_String_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitString", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_String_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitMethodref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Methodref_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitMethodref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Methodref_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitNameAndType", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitNameAndType", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitMethodHandle", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodHandle_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitMethodHandle", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodHandle_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFloat", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Float_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFloat", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Float_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitUtf8", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitUtf8", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitInvokeDynamic", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InvokeDynamic_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitInvokeDynamic", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InvokeDynamic_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitInteger", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Integer_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitInteger", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Integer_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitMethodType", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodType_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitMethodType", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodType_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDynamicConstant", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Dynamic_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDynamicConstant", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Dynamic_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ConstantPoolWriter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public ConstantPoolWriter() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ClassWriter$ConstantPoolWriter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CPInfo;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)I", "protected")]
		public int write(Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitModule(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Module_info arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitModule(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Module_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitPackage(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Package_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitPackage(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Package_info arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitClass(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Class_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitClass(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Class_info arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CPRefInfo;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;", "protected")]
		public Dova.JDK.java.lang.Integer writeRef(Dova.JDK.com.sun.tools.classfile.ConstantPool.CPRefInfo arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InterfaceMethodref_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitInterfaceMethodref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_InterfaceMethodref_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InterfaceMethodref_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitInterfaceMethodref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_InterfaceMethodref_info arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitFieldref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Fieldref_info arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitFieldref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Fieldref_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Double_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitDouble(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Double_info arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Double_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitDouble(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Double_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Long_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitLong(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Long_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Long_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitLong(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Long_info arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_String_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitString(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_String_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_String_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitString(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_String_info arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Methodref_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitMethodref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Methodref_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Methodref_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitMethodref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Methodref_info arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitNameAndType(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_NameAndType_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitNameAndType(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_NameAndType_info arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodHandle_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitMethodHandle(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_MethodHandle_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodHandle_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitMethodHandle(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_MethodHandle_info arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Float_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitFloat(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Float_info arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Float_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitFloat(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Float_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitUtf8(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Utf8_info arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitUtf8(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Utf8_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InvokeDynamic_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitInvokeDynamic(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_InvokeDynamic_info arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InvokeDynamic_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitInvokeDynamic(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_InvokeDynamic_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Integer_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitInteger(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Integer_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Integer_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitInteger(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Integer_info arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodType_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitMethodType(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_MethodType_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodType_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitMethodType(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_MethodType_info arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Dynamic_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitDynamicConstant(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Dynamic_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Dynamic_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer visitDynamicConstant(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Dynamic_info arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;", "protected static")]
	public partial class ClassOutputStream
		: Dova.JDK.java.io.ByteArrayOutputStream
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ClassOutputStream()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "d", "Ljava/io/DataOutputStream;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ClassOutputStream", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeInt", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeUTF", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeFloat", "(F)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeTo", "(Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeByte", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeShort", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeLong", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeDouble", "(D)V"));
		}

		[JniSignatureAttribute("Ljava/io/DataOutputStream;", "private final")]
		public Dova.JDK.java.io.DataOutputStream d_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.DataOutputStream>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ClassOutputStream(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public ClassOutputStream() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)V", "public")]
		public void writeInt(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void writeUTF(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(F)V", "public")]
		public void writeFloat(float arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V", "public")]
		public void writeTo(Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void writeByte(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void writeShort(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(J)V", "public")]
		public void writeLong(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(D)V", "public")]
		public void writeDouble(double arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ClassWriter$AnnotationWriter;", "protected static")]
	public partial class AnnotationWriter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.classfile.Annotation.element_value.Visitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AnnotationWriter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/ClassWriter$AnnotationWriter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AnnotationWriter", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "write", "(Lcom/sun/tools/classfile/TypeAnnotation;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "write", "(Lcom/sun/tools/classfile/Annotation$element_value_pair;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "write", "(Lcom/sun/tools/classfile/Annotation$element_value;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "write", "(Lcom/sun/tools/classfile/TypeAnnotation$Position;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "write", "([Lcom/sun/tools/classfile/Annotation;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "write", "([Lcom/sun/tools/classfile/TypeAnnotation;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "write", "(Lcom/sun/tools/classfile/Annotation;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitAnnotation", "(Lcom/sun/tools/classfile/Annotation$Annotation_element_value;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitAnnotation", "(Lcom/sun/tools/classfile/Annotation$Annotation_element_value;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitEnum", "(Lcom/sun/tools/classfile/Annotation$Enum_element_value;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitEnum", "(Lcom/sun/tools/classfile/Annotation$Enum_element_value;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitArray", "(Lcom/sun/tools/classfile/Annotation$Array_element_value;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitArray", "(Lcom/sun/tools/classfile/Annotation$Array_element_value;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitClass", "(Lcom/sun/tools/classfile/Annotation$Class_element_value;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitClass", "(Lcom/sun/tools/classfile/Annotation$Class_element_value;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitPrimitive", "(Lcom/sun/tools/classfile/Annotation$Primitive_element_value;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitPrimitive", "(Lcom/sun/tools/classfile/Annotation$Primitive_element_value;Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AnnotationWriter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public AnnotationWriter() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ClassWriter$AnnotationWriter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/TypeAnnotation;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V", "public")]
		public void write(Dova.JDK.com.sun.tools.classfile.TypeAnnotation arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Annotation$element_value_pair;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V", "public")]
		public void write(Dova.JDK.com.sun.tools.classfile.Annotation.element_value_pair arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Annotation$element_value;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V", "public")]
		public void write(Dova.JDK.com.sun.tools.classfile.Annotation.element_value arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/TypeAnnotation$Position;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V", "private")]
		public void write(Dova.JDK.com.sun.tools.classfile.TypeAnnotation.Position arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("([Lcom/sun/tools/classfile/Annotation;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V", "public")]
		public void write(JavaArray<Dova.JDK.com.sun.tools.classfile.Annotation> arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("([Lcom/sun/tools/classfile/TypeAnnotation;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V", "public")]
		public void write(JavaArray<Dova.JDK.com.sun.tools.classfile.TypeAnnotation> arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Annotation;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V", "public")]
		public void write(Dova.JDK.com.sun.tools.classfile.Annotation arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Annotation$Annotation_element_value;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitAnnotation(Dova.JDK.com.sun.tools.classfile.Annotation.Annotation_element_value arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Annotation$Annotation_element_value;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitAnnotation(Dova.JDK.com.sun.tools.classfile.Annotation.Annotation_element_value arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Annotation$Enum_element_value;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitEnum(Dova.JDK.com.sun.tools.classfile.Annotation.Enum_element_value arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Annotation$Enum_element_value;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitEnum(Dova.JDK.com.sun.tools.classfile.Annotation.Enum_element_value arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Annotation$Array_element_value;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitArray(Dova.JDK.com.sun.tools.classfile.Annotation.Array_element_value arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Annotation$Array_element_value;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitArray(Dova.JDK.com.sun.tools.classfile.Annotation.Array_element_value arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Annotation$Class_element_value;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitClass(Dova.JDK.com.sun.tools.classfile.Annotation.Class_element_value arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Annotation$Class_element_value;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitClass(Dova.JDK.com.sun.tools.classfile.Annotation.Class_element_value arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Annotation$Primitive_element_value;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visitPrimitive(Dova.JDK.com.sun.tools.classfile.Annotation.Primitive_element_value arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Annotation$Primitive_element_value;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitPrimitive(Dova.JDK.com.sun.tools.classfile.Annotation.Primitive_element_value arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ClassWriter$StackMapTableWriter;", "protected static")]
	public partial class StackMapTableWriter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.stack_map_frame.Visitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StackMapTableWriter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/ClassWriter$StackMapTableWriter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "StackMapTableWriter", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "write", "(Lcom/sun/tools/classfile/StackMapTable_attribute$stack_map_frame;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeVerificationTypeInfo", "(Lcom/sun/tools/classfile/StackMapTable_attribute$verification_type_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visit_full_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$full_frame;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visit_full_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$full_frame;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visit_same_locals_1_stack_item_frame_extended", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame_extended;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visit_same_locals_1_stack_item_frame_extended", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame_extended;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visit_chop_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$chop_frame;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visit_chop_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$chop_frame;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visit_same_frame_extended", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame_extended;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visit_same_frame_extended", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame_extended;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visit_append_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$append_frame;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visit_append_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$append_frame;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visit_same_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visit_same_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visit_same_locals_1_stack_item_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visit_same_locals_1_stack_item_frame", "(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StackMapTableWriter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public StackMapTableWriter() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ClassWriter$StackMapTableWriter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$stack_map_frame;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V", "public")]
		public void write(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.stack_map_frame arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$verification_type_info;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)V", "protected")]
		public void writeVerificationTypeInfo(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.verification_type_info arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$full_frame;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visit_full_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.full_frame arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
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

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame_extended;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visit_same_locals_1_stack_item_frame_extended(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_locals_1_stack_item_frame_extended arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame_extended;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visit_same_locals_1_stack_item_frame_extended(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_locals_1_stack_item_frame_extended arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$chop_frame;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visit_chop_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.chop_frame arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$chop_frame;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visit_chop_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.chop_frame arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame_extended;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visit_same_frame_extended(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_frame_extended arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame_extended;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visit_same_frame_extended(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_frame_extended arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$append_frame;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visit_append_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.append_frame arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$append_frame;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visit_append_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.append_frame arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visit_same_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_frame arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_frame;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visit_same_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_frame arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visit_same_locals_1_stack_item_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_locals_1_stack_item_frame arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/StackMapTable_attribute$same_locals_1_stack_item_frame;Lcom/sun/tools/classfile/ClassWriter$ClassOutputStream;)Ljava/lang/Void;", "public")]
		public Dova.JDK.java.lang.Void visit_same_locals_1_stack_item_frame(Dova.JDK.com.sun.tools.classfile.StackMapTable_attribute.same_locals_1_stack_item_frame arg0, Dova.JDK.com.sun.tools.classfile.ClassWriter.ClassOutputStream arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
		}
	}
}
