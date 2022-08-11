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

namespace Dova.JDK.com.sun.tools.javac.jvm;

[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/ClassWriter;", "public")]
public partial class ClassWriter
	: Dova.JDK.com.sun.tools.javac.jvm.ClassFile
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/jvm/ClassWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "classWriterKey", "Lcom/sun/tools/javac/util/Context$Key;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "options", "Lcom/sun/tools/javac/util/Options;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "verbose", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "emitSourceFile", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genCrt", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "debugstackmap", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "preview", "Lcom/sun/tools/javac/code/Preview;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Lcom/sun/tools/javac/jvm/Target;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "source", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "types", "Lcom/sun/tools/javac/code/Types;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "check", "Lcom/sun/tools/javac/comp/Check;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "multiModuleMode", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "extraAttributeHooks", "Lcom/sun/tools/javac/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DATA_BUF_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_BUF_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "databuf", "Lcom/sun/tools/javac/util/ByteBuffer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "poolbuf", "Lcom/sun/tools/javac/util/ByteBuffer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "poolWriter", "Lcom/sun/tools/javac/jvm/PoolWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "log", "Lcom/sun/tools/javac/util/Log;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "names", "Lcom/sun/tools/javac/util/Names;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fileManager", "Ljavax/tools/JavaFileManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SAME_FRAME_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SAME_LOCALS_1_STACK_ITEM_EXTENDED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SAME_FRAME_EXTENDED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FULL_FRAME", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_LOCAL_LENGTH_DIFF", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dumpClassModifiers", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dumpFieldModifiers", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dumpInnerClassModifiers", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dumpMethodModifiers", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "flagName", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "awriter", "Lcom/sun/tools/javac/jvm/ClassWriter$AttributeWriter;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Context;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putChar", "(Lcom/sun/tools/javac/util/ByteBuffer;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putInt", "(Lcom/sun/tools/javac/util/ByteBuffer;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeFields", "(Lcom/sun/tools/javac/code/Scope;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instance", "(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/jvm/ClassWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastModified", "(Ljavax/tools/FileObject;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeClass", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)Ljavax/tools/JavaFileObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeMethods", "(Lcom/sun/tools/javac/code/Scope;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeField", "(Lcom/sun/tools/javac/code/Symbol$VarSymbol;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeMethod", "(Lcom/sun/tools/javac/code/Symbol$MethodSymbol;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "flagNames", "(J)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeEnclosingMethodAttribute", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeEnclosingMethodAttribute", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeAttr", "(Lcom/sun/tools/javac/util/Name;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endAttr", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeFlagAttrs", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeJavaAnnotations", "(Lcom/sun/tools/javac/util/List;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeTypeAnnotations", "(Lcom/sun/tools/javac/util/List;Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeCompoundAttribute", "(Lcom/sun/tools/javac/code/Attribute$Compound;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeParamAnnotations", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Attribute$RetentionPolicy;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeParamAnnotations", "(Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Lcom/sun/tools/javac/code/Attribute$RetentionPolicy;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeTypeAnnotation", "(Lcom/sun/tools/javac/code/Attribute$TypeCompound;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writePosition", "(Lcom/sun/tools/javac/code/TypeAnnotationPosition;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adjustFlags", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "beginAttrs", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeMemberAttrs", "(Lcom/sun/tools/javac/code/Symbol;Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endAttrs", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listNested", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/ListBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeExtraAttributes", "(Lcom/sun/tools/javac/code/Symbol;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeCode", "(Lcom/sun/tools/javac/jvm/Code;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeMethodParametersAttr", "(Lcom/sun/tools/javac/code/Symbol$MethodSymbol;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeParameterAttrs", "(Lcom/sun/tools/javac/util/List;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needsLocalVariableTypeEntry", "(Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeStackMap", "(Lcom/sun/tools/javac/jvm/Code;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeStackMapType", "(Lcom/sun/tools/javac/code/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeClassFile", "(Ljava/io/OutputStream;Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeModuleAttribute", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeExtraClassAttributes", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeNestMembersIfNeeded", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeNestHostIfNeeded", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeRecordAttribute", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writePermittedSubclassesIfNeeded", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeBootstrapMethods", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeInnerClasses", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addExtraAttributes", "(Ljava/util/function/ToIntFunction;)V"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Context$Key;", "protected static final")]
	public static Dova.JDK.com.sun.tools.javac.util.Context.Key classWriterKey_Property
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

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Options;", "private final")]
	public Dova.JDK.com.sun.tools.javac.util.Options options_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Options>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool verbose_Property
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
	public bool emitSourceFile_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool genCrt_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool debugstackmap_Property
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

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Preview;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Preview preview_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Preview>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/Target;", "private")]
	public Dova.JDK.com.sun.tools.javac.jvm.Target target_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.Target>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Source source_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Types types_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Check;", "private")]
	public Dova.JDK.com.sun.tools.javac.comp.Check check_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Check>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "public")]
	public bool multiModuleMode_Property
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

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.List extraAttributeHooks_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int DATA_BUF_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int CLASS_BUF_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/ByteBuffer;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.ByteBuffer databuf_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.ByteBuffer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/ByteBuffer;", "")]
	public Dova.JDK.com.sun.tools.javac.util.ByteBuffer poolbuf_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.ByteBuffer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/PoolWriter;", "final")]
	public Dova.JDK.com.sun.tools.javac.jvm.PoolWriter poolWriter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.PoolWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Log;", "private final")]
	public Dova.JDK.com.sun.tools.javac.util.Log log_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Log>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Names;", "private final")]
	public Dova.JDK.com.sun.tools.javac.util.Names names_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Names>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/tools/JavaFileManager;", "private final")]
	public Dova.JDK.javax.tools.JavaFileManager fileManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int SAME_FRAME_SIZE_Property
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
	public static int SAME_LOCALS_1_STACK_ITEM_EXTENDED_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int SAME_FRAME_EXTENDED_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int FULL_FRAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int MAX_LOCAL_LENGTH_DIFF_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool dumpClassModifiers_Property
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
	public bool dumpFieldModifiers_Property
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
	public bool dumpInnerClassModifiers_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool dumpMethodModifiers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> flagName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/ClassWriter$AttributeWriter;", "")]
	public Dova.JDK.com.sun.tools.javac.jvm.ClassWriter.AttributeWriter awriter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.ClassWriter.AttributeWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ClassWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)V", "protected")]
	public ClassWriter(Dova.JDK.com.sun.tools.javac.util.Context arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/jvm/ClassWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/ByteBuffer;II)V", "")]
	public void putChar(Dova.JDK.com.sun.tools.javac.util.ByteBuffer arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/ByteBuffer;II)V", "")]
	public void putInt(Dova.JDK.com.sun.tools.javac.util.ByteBuffer arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Scope;)V", "")]
	public void writeFields(Dova.JDK.com.sun.tools.javac.code.Scope arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/jvm/ClassWriter;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.jvm.ClassWriter instance(Dova.JDK.com.sun.tools.javac.util.Context arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.ClassWriter>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/FileObject;)J", "")]
	public long getLastModified(Dova.JDK.javax.tools.FileObject arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)Ljavax/tools/JavaFileObject;", "public")]
	public Dova.JDK.javax.tools.JavaFileObject writeClass(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Scope;)V", "")]
	public void writeMethods(Dova.JDK.com.sun.tools.javac.code.Scope arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$VarSymbol;)V", "")]
	public void writeField(Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$MethodSymbol;)V", "")]
	public void writeMethod(Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(J)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String flagNames(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)I", "protected")]
	public int writeEnclosingMethodAttribute(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)I", "")]
	public int writeEnclosingMethodAttribute(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)I", "public")]
	public int writeAttr(Dova.JDK.com.sun.tools.javac.util.Name arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void endAttr(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(J)I", "")]
	public int writeFlagAttrs(long arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)I", "")]
	public int writeJavaAnnotations(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Z)I", "")]
	public int writeTypeAnnotations(Dova.JDK.com.sun.tools.javac.util.List arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Attribute$Compound;)V", "")]
	public void writeCompoundAttribute(Dova.JDK.com.sun.tools.javac.code.Attribute.Compound arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Attribute$RetentionPolicy;)V", "private")]
	public void writeParamAnnotations(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.code.Attribute.RetentionPolicy arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Lcom/sun/tools/javac/code/Attribute$RetentionPolicy;)V", "private")]
	public void writeParamAnnotations(Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol arg0, Dova.JDK.com.sun.tools.javac.code.Attribute.RetentionPolicy arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Attribute$TypeCompound;)V", "")]
	public void writeTypeAnnotation(Dova.JDK.com.sun.tools.javac.code.Attribute.TypeCompound arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeAnnotationPosition;)V", "")]
	public void writePosition(Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(J)I", "")]
	public int adjustFlags(long arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "")]
	public int beginAttrs()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Z)I", "")]
	public int writeMemberAttrs(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)V", "")]
	public void endAttrs(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/util/ListBuffer;)V", "private")]
	public void listNested(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.util.ListBuffer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)I", "protected")]
	public int writeExtraAttributes(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/jvm/Code;)V", "")]
	public void writeCode(Dova.JDK.com.sun.tools.javac.jvm.Code arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$MethodSymbol;)I", "")]
	public int writeMethodParametersAttr(Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)I", "")]
	public int writeParameterAttrs(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "private")]
	public bool needsLocalVariableTypeEntry(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/jvm/Code;)V", "")]
	public void writeStackMap(Dova.JDK.com.sun.tools.javac.jvm.Code arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)V", "")]
	public void writeStackMapType(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/OutputStream;Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V", "public")]
	public void writeClassFile(Dova.JDK.java.io.OutputStream arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)I", "")]
	public int writeModuleAttribute(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)I", "protected")]
	public int writeExtraClassAttributes(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)I", "")]
	public int writeNestMembersIfNeeded(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)I", "")]
	public int writeNestHostIfNeeded(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)I", "")]
	public int writeRecordAttribute(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)I", "")]
	public int writePermittedSubclassesIfNeeded(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "")]
	public void writeBootstrapMethods()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41]);
	}

	[JniSignatureAttribute("()V", "")]
	public void writeInnerClasses()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42]);
	}

	[JniSignatureAttribute("(Ljava/util/function/ToIntFunction;)V", "public")]
	public void addExtraAttributes(Dova.JDK.java.util.function.ToIntFunction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/ClassWriter$AttributeWriter;", "")]
	public partial class AttributeWriter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.javac.code.Attribute.Visitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AttributeWriter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/jvm/ClassWriter$AttributeWriter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/jvm/ClassWriter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/jvm/ClassWriter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnum", "(Lcom/sun/tools/javac/code/Attribute$Enum;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArray", "(Lcom/sun/tools/javac/code/Attribute$Array;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClass", "(Lcom/sun/tools/javac/code/Attribute$Class;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstant", "(Lcom/sun/tools/javac/code/Attribute$Constant;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCompound", "(Lcom/sun/tools/javac/code/Attribute$Compound;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitError", "(Lcom/sun/tools/javac/code/Attribute$Error;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/ClassWriter;", "final")]
		public Dova.JDK.com.sun.tools.javac.jvm.ClassWriter this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.ClassWriter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AttributeWriter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/jvm/ClassWriter;)V", "")]
		public AttributeWriter(Dova.JDK.com.sun.tools.javac.jvm.ClassWriter arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/jvm/ClassWriter$AttributeWriter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Attribute$Enum;)V", "public")]
		public void visitEnum(Dova.JDK.com.sun.tools.javac.code.Attribute.Enum arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Attribute$Array;)V", "public")]
		public void visitArray(Dova.JDK.com.sun.tools.javac.code.Attribute.Array arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Attribute$Class;)V", "public")]
		public void visitClass(Dova.JDK.com.sun.tools.javac.code.Attribute.Class arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Attribute$Constant;)V", "public")]
		public void visitConstant(Dova.JDK.com.sun.tools.javac.code.Attribute.Constant arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Attribute$Compound;)V", "public")]
		public void visitCompound(Dova.JDK.com.sun.tools.javac.code.Attribute.Compound arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Attribute$Error;)V", "public")]
		public void visitError(Dova.JDK.com.sun.tools.javac.code.Attribute.Error arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/ClassWriter$StackMapTableFrame;", "abstract static")]
	public partial class StackMapTableFrame
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StackMapTableFrame()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/jvm/ClassWriter$StackMapTableFrame;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "([Lcom/sun/tools/javac/code/Type;[Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Types;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Lcom/sun/tools/javac/jvm/Code$StackMapFrame;I[Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Types;)Lcom/sun/tools/javac/jvm/ClassWriter$StackMapTableFrame;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/javac/jvm/ClassWriter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFrameType", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSameType", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Types;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isInt", "(Lcom/sun/tools/javac/code/Type;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StackMapTableFrame(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public StackMapTableFrame() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/jvm/ClassWriter$StackMapTableFrame;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([Lcom/sun/tools/javac/code/Type;[Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Types;)I", "static")]
		public static int compare(JavaArray<Dova.JDK.com.sun.tools.javac.code.Type> arg0, JavaArray<Dova.JDK.com.sun.tools.javac.code.Type> arg1, Dova.JDK.com.sun.tools.javac.code.Types arg2)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/jvm/Code$StackMapFrame;I[Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Types;)Lcom/sun/tools/javac/jvm/ClassWriter$StackMapTableFrame;", "static")]
		public static Dova.JDK.com.sun.tools.javac.jvm.ClassWriter.StackMapTableFrame getInstance(Dova.JDK.com.sun.tools.javac.jvm.Code.StackMapFrame arg0, int arg1, JavaArray<Dova.JDK.com.sun.tools.javac.code.Type> arg2, Dova.JDK.com.sun.tools.javac.code.Types arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.ClassWriter.StackMapTableFrame>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/jvm/ClassWriter;)V", "")]
		public void write(Dova.JDK.com.sun.tools.javac.jvm.ClassWriter arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()I", "abstract")]
		public int getFrameType()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Types;)Z", "static")]
		public static bool isSameType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Types arg2)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "static")]
		public static bool isInt(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/ClassWriter$StackMapTableFrame$SameLocals1StackItemFrame;", "static")]
		public partial class SameLocals1StackItemFrame
			: Dova.JDK.com.sun.tools.javac.jvm.ClassWriter.StackMapTableFrame
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SameLocals1StackItemFrame()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/jvm/ClassWriter$StackMapTableFrame$SameLocals1StackItemFrame;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offsetDelta", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stack", "Lcom/sun/tools/javac/code/Type;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILcom/sun/tools/javac/code/Type;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/javac/jvm/ClassWriter;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFrameType", "()I"));
			}

			[JniSignatureAttribute("I", "final")]
			public int offsetDelta_Property
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

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "final")]
			public Dova.JDK.com.sun.tools.javac.code.Type stack_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SameLocals1StackItemFrame(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(ILcom/sun/tools/javac/code/Type;)V", "")]
			public SameLocals1StackItemFrame(int arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/jvm/ClassWriter$StackMapTableFrame$SameLocals1StackItemFrame;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/javac/jvm/ClassWriter;)V", "")]
			public void write(Dova.JDK.com.sun.tools.javac.jvm.ClassWriter arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("()I", "")]
			public int getFrameType()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/ClassWriter$StackMapTableFrame$SameFrame;", "static")]
		public partial class SameFrame
			: Dova.JDK.com.sun.tools.javac.jvm.ClassWriter.StackMapTableFrame
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SameFrame()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/jvm/ClassWriter$StackMapTableFrame$SameFrame;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offsetDelta", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/javac/jvm/ClassWriter;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFrameType", "()I"));
			}

			[JniSignatureAttribute("I", "final")]
			public int offsetDelta_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SameFrame(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(I)V", "")]
			public SameFrame(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/jvm/ClassWriter$StackMapTableFrame$SameFrame;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/javac/jvm/ClassWriter;)V", "")]
			public void write(Dova.JDK.com.sun.tools.javac.jvm.ClassWriter arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("()I", "")]
			public int getFrameType()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/ClassWriter$StackMapTableFrame$AppendFrame;", "static")]
		public partial class AppendFrame
			: Dova.JDK.com.sun.tools.javac.jvm.ClassWriter.StackMapTableFrame
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AppendFrame()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/jvm/ClassWriter$StackMapTableFrame$AppendFrame;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "frameType", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offsetDelta", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "locals", "[Lcom/sun/tools/javac/code/Type;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(II[Lcom/sun/tools/javac/code/Type;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/javac/jvm/ClassWriter;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFrameType", "()I"));
			}

			[JniSignatureAttribute("I", "final")]
			public int frameType_Property
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

			[JniSignatureAttribute("I", "final")]
			public int offsetDelta_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/javac/code/Type;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.javac.code.Type> locals_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Type>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AppendFrame(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(II[Lcom/sun/tools/javac/code/Type;)V", "")]
			public AppendFrame(int arg0, int arg1, JavaArray<Dova.JDK.com.sun.tools.javac.code.Type> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/jvm/ClassWriter$StackMapTableFrame$AppendFrame;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/javac/jvm/ClassWriter;)V", "")]
			public void write(Dova.JDK.com.sun.tools.javac.jvm.ClassWriter arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("()I", "")]
			public int getFrameType()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/ClassWriter$StackMapTableFrame$ChopFrame;", "static")]
		public partial class ChopFrame
			: Dova.JDK.com.sun.tools.javac.jvm.ClassWriter.StackMapTableFrame
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ChopFrame()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/jvm/ClassWriter$StackMapTableFrame$ChopFrame;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "frameType", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offsetDelta", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(II)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/javac/jvm/ClassWriter;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFrameType", "()I"));
			}

			[JniSignatureAttribute("I", "final")]
			public int frameType_Property
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

			[JniSignatureAttribute("I", "final")]
			public int offsetDelta_Property
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
			public ChopFrame(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(II)V", "")]
			public ChopFrame(int arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/jvm/ClassWriter$StackMapTableFrame$ChopFrame;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/javac/jvm/ClassWriter;)V", "")]
			public void write(Dova.JDK.com.sun.tools.javac.jvm.ClassWriter arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("()I", "")]
			public int getFrameType()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/ClassWriter$StackMapTableFrame$FullFrame;", "static")]
		public partial class FullFrame
			: Dova.JDK.com.sun.tools.javac.jvm.ClassWriter.StackMapTableFrame
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static FullFrame()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/jvm/ClassWriter$StackMapTableFrame$FullFrame;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offsetDelta", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "locals", "[Lcom/sun/tools/javac/code/Type;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stack", "[Lcom/sun/tools/javac/code/Type;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I[Lcom/sun/tools/javac/code/Type;[Lcom/sun/tools/javac/code/Type;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lcom/sun/tools/javac/jvm/ClassWriter;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFrameType", "()I"));
			}

			[JniSignatureAttribute("I", "final")]
			public int offsetDelta_Property
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

			[JniSignatureAttribute("[Lcom/sun/tools/javac/code/Type;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.javac.code.Type> locals_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Type>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lcom/sun/tools/javac/code/Type;", "final")]
			public JavaArray<Dova.JDK.com.sun.tools.javac.code.Type> stack_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Type>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public FullFrame(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(I[Lcom/sun/tools/javac/code/Type;[Lcom/sun/tools/javac/code/Type;)V", "")]
			public FullFrame(int arg0, JavaArray<Dova.JDK.com.sun.tools.javac.code.Type> arg1, JavaArray<Dova.JDK.com.sun.tools.javac.code.Type> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/jvm/ClassWriter$StackMapTableFrame$FullFrame;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/javac/jvm/ClassWriter;)V", "")]
			public void write(Dova.JDK.com.sun.tools.javac.jvm.ClassWriter arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("()I", "")]
			public int getFrameType()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/ClassWriter$StringOverflow;", "public static")]
	public partial class StringOverflow
		: Dova.JDK.java.lang.RuntimeException
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StringOverflow()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/jvm/ClassWriter$StringOverflow;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String value_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StringOverflow(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public StringOverflow(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/jvm/ClassWriter$StringOverflow;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/ClassWriter$PoolOverflow;", "public static")]
	public partial class PoolOverflow
		: Dova.JDK.java.lang.RuntimeException
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PoolOverflow()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/jvm/ClassWriter$PoolOverflow;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PoolOverflow(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public PoolOverflow() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/jvm/ClassWriter$PoolOverflow;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
