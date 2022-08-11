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

namespace Dova.JDK.com.sun.tools.javac.code;

[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "public abstract")]
public partial class Type
	: Dova.JDK.com.sun.tools.javac.code.AnnoConstruct
	, Dova.JDK.javax.lang.model.type.TypeMirror
	, Dova.JDK.com.sun.tools.javac.jvm.PoolConstant
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Type()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "metadata", "Lcom/sun/tools/javac/code/TypeMetadata;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "noType", "Lcom/sun/tools/javac/code/Type$JCNoType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "recoveryType", "Lcom/sun/tools/javac/code/Type$JCNoType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "stuckType", "Lcom/sun/tools/javac/code/Type$JCNoType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "moreInfo", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tsym", "Lcom/sun/tools/javac/code/Symbol$TypeSymbol;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "stripMetadata", "Lcom/sun/tools/javac/code/Types$TypeMapping;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/TypeMetadata;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toString", "(Lcom/sun/tools/javac/util/List;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInterface", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitive", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "map", "(Lcom/sun/tools/javac/code/Types$TypeMapping;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "map", "(Lcom/sun/tools/javac/code/Types$TypeMapping;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "contains", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterTypes", "()Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "filter", "(Lcom/sun/tools/javac/util/List;Ljava/util/function/Predicate;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationsByType", "(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFinal", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "baseType", "()Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stringValue", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/code/TypeTag;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNumeric", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isIntegral", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asMethodType", "()Lcom/sun/tools/javac/code/Type$MethodType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "poolTag", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "poolKey", "(Lcom/sun/tools/javac/code/Types;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isUnion", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stripMetadataIfNeeded", "()Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "constType", "(Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingType", "()Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBound", "()Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isParameterized", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isErroneous", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isErroneous", "(Lcom/sun/tools/javac/util/List;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "argtypes", "(Z)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMetadata", "()Lcom/sun/tools/javac/code/TypeMetadata;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getModelTypes", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModelType", "()Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needsStripping", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stripMetadata", "()Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMetadataOfKind", "(Lcom/sun/tools/javac/code/TypeMetadata$Entry$Kind;)Lcom/sun/tools/javac/code/TypeMetadata$Entry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "baseTypes", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnnotated", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendAnnotationsString", "(Ljava/lang/StringBuilder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendAnnotationsString", "(Ljava/lang/StringBuilder;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "constValue", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeNoMetadata", "()Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equalsIgnoreMetadata", "(Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "containsAny", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsAny", "(Lcom/sun/tools/javac/util/List;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitiveOrVoid", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isReference", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNullOrReference", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPartial", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFalse", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTrue", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLowerBound", "()Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allparams", "()Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRaw", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCompound", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isIntersection", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSuperBound", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExtendsBound", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isUnbound", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withTypeVar", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotatedType", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asElement", "()Lcom/sun/tools/javac/code/Symbol$TypeSymbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasTag", "(Lcom/sun/tools/javac/code/TypeTag;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationMirrors_0", "()Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationMirrors_1", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReceiverType", "()Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThrownTypes", "()Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljavax/lang/model/type/TypeKind;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOriginalType", "()Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments", "()Lcom/sun/tools/javac/util/List;"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/TypeMetadata;", "protected final")]
	public Dova.JDK.com.sun.tools.javac.code.TypeMetadata metadata_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeMetadata>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$JCNoType;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Type.JCNoType noType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.JCNoType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$JCNoType;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Type.JCNoType recoveryType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.JCNoType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$JCNoType;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Type.JCNoType stuckType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.JCNoType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "public static")]
	public static bool moreInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol$TypeSymbol;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol tsym_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$TypeMapping;", "private static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Types.TypeMapping stripMetadata_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.TypeMapping>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Type(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/TypeMetadata;)V", "public")]
	public Type(Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg0, Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String toString(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isInterface()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isPrimitive()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types$TypeMapping;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type map(Dova.JDK.com.sun.tools.javac.code.Types.TypeMapping arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types$TypeMapping;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type map(Dova.JDK.com.sun.tools.javac.code.Types.TypeMapping arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool contains(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type;)Z", "public static")]
	public static bool contains(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type getReturnType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List getParameterTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Ljava/util/function/Predicate;)Lcom/sun/tools/javac/util/List;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.util.List filter(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.java.util.function.Predicate arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", "public")]
	public Dova.JDK.java.lang.Object getAnnotation(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", "public")]
	public JavaArray<Dova.JDK.java.lang.Object> getAnnotationsByType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.javac.code.Type.Visitor arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object accept(Dova.JDK.javax.lang.model.type.TypeVisitor arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isFinal()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void complete()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18]);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type baseType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String stringValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/code/TypeTag;", "public abstract")]
	public Dova.JDK.com.sun.tools.javac.code.TypeTag getTag()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeTag>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isNumeric()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isIntegral()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type$MethodType;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type.MethodType asMethodType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.MethodType>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int poolTag()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object poolKey(Dova.JDK.com.sun.tools.javac.code.Types arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isUnion()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type stripMetadataIfNeeded()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type constType(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type getEnclosingType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type getUpperBound()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isParameterized()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[32]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isErroneous()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[33]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Z", "public static")]
	public static bool isErroneous(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[34], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Z)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String argtypes(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/code/TypeMetadata;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.TypeMetadata getMetadata()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeMetadata>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.util.List getModelTypes(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type getModelType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool needsStripping()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[39]);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type stripMetadata()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;", "public abstract")]
	public Dova.JDK.com.sun.tools.javac.code.Type cloneWithMetadata(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata$Entry$Kind;)Lcom/sun/tools/javac/code/TypeMetadata$Entry;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.TypeMetadata.Entry getMetadataOfKind(Dova.JDK.com.sun.tools.javac.code.TypeMetadata.Entry.Kind arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeMetadata.Entry>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.util.List baseTypes(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isAnnotated()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[44]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuilder;)V", "protected")]
	public void appendAnnotationsString(Dova.JDK.java.lang.StringBuilder arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuilder;Z)V", "protected")]
	public void appendAnnotationsString(Dova.JDK.java.lang.StringBuilder arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object constValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "protected")]
	public Dova.JDK.com.sun.tools.javac.code.Type typeNoMetadata()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "public")]
	public bool equalsIgnoreMetadata(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Z", "public static")]
	public static bool containsAny(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[50], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Z", "public")]
	public bool containsAny(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isPrimitiveOrVoid()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[52]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isReference()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[53]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isNullOrReference()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[54]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isPartial()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[55]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isFalse()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[56]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isTrue()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[57]);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type getLowerBound()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List allparams()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isRaw()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[60]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isCompound()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[61]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isIntersection()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[62]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isSuperBound()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[63]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isExtendsBound()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[64]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isUnbound()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[65]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type withTypeVar(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type annotatedType(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Symbol$TypeSymbol;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol asElement()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeTag;)Z", "public")]
	public bool hasTag(Dova.JDK.com.sun.tools.javac.code.TypeTag arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[69], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List getAnnotationMirrors_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
	public Dova.JDK.java.util.List getAnnotationMirrors_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type getReceiverType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[72]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List getThrownTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/type/TypeKind;", "public")]
	public Dova.JDK.javax.lang.model.type.TypeKind getKind()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[74]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeKind>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type getOriginalType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List getTypeArguments()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$Visitor;", "public abstract static interface")]
	public partial interface Visitor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Visitor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$Visitor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType", "(Lcom/sun/tools/javac/code/Type$ArrayType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPackageType", "(Lcom/sun/tools/javac/code/Type$PackageType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVar", "(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCapturedType", "(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForAll", "(Lcom/sun/tools/javac/code/Type$ForAll;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUndetVar", "(Lcom/sun/tools/javac/code/Type$UndetVar;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType", "(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcardType", "(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodType", "(Lcom/sun/tools/javac/code/Type$MethodType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModuleType", "(Lcom/sun/tools/javac/code/Type$ModuleType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitErrorType", "(Lcom/sun/tools/javac/code/Type$ErrorType;Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ArrayType;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitArrayType(Dova.JDK.com.sun.tools.javac.code.Type.ArrayType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$PackageType;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitPackageType(Dova.JDK.com.sun.tools.javac.code.Type.PackageType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitTypeVar(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitCapturedType(Dova.JDK.com.sun.tools.javac.code.Type.CapturedType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ForAll;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitForAll(Dova.JDK.com.sun.tools.javac.code.Type.ForAll arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitUndetVar(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitClassType(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitWildcardType(Dova.JDK.com.sun.tools.javac.code.Type.WildcardType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$MethodType;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitMethodType(Dova.JDK.com.sun.tools.javac.code.Type.MethodType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ModuleType;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitModuleType(Dova.JDK.com.sun.tools.javac.code.Type.ModuleType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ErrorType;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitErrorType(Dova.JDK.com.sun.tools.javac.code.Type.ErrorType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$ArrayType;", "public static")]
	public partial class ArrayType
		: Dova.JDK.com.sun.tools.javac.code.Type
		, Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant
		, Dova.JDK.javax.lang.model.type.ArrayType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ArrayType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$ArrayType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "elemtype", "Lcom/sun/tools/javac/code/Type;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Type$ArrayType;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/TypeMetadata;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Lcom/sun/tools/javac/code/Type;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_0", "()Ljavax/lang/model/type/TypeMirror;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_1", "()Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVarargs", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeVarargs", "()Lcom/sun/tools/javac/code/Type$ArrayType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/code/TypeTag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "poolTag", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isParameterized", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isErroneous", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_0", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$ArrayType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_1", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isReference", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNullOrReference", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allparams", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRaw", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationMirrors", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljavax/lang/model/type/TypeKind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type elemtype_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ArrayType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ArrayType;)V", "public")]
		public ArrayType(Dova.JDK.com.sun.tools.javac.code.Type.ArrayType arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/TypeMetadata;)V", "public")]
		public ArrayType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg1, Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)V", "public")]
		public ArrayType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$ArrayType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "public")]
		public bool contains(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeMirror;", "public volatile")]
		public Dova.JDK.javax.lang.model.type.TypeMirror getComponentType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type getComponentType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.javax.lang.model.type.TypeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.javac.code.Type.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isVarargs()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type$ArrayType;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.ArrayType makeVarargs()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.ArrayType>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void complete()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/TypeTag;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.TypeTag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeTag>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int poolTag()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isParameterized()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isErroneous()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$ArrayType;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.ArrayType cloneWithMetadata_0(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.ArrayType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type cloneWithMetadata_1(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isReference()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isNullOrReference()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List allparams()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isRaw()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getAnnotationMirrors()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeKind;", "public")]
		public Dova.JDK.javax.lang.model.type.TypeKind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeKind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$JCNoType;", "public static")]
	public partial class JCNoType
		: Dova.JDK.com.sun.tools.javac.code.Type
		, Dova.JDK.javax.lang.model.type.NoType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCNoType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$JCNoType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/code/TypeTag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_0", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$JCNoType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_1", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCompound", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationMirrors", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljavax/lang/model/type/TypeKind;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCNoType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public JCNoType() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$JCNoType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.javax.lang.model.type.TypeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/TypeTag;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.TypeTag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeTag>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$JCNoType;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.JCNoType cloneWithMetadata_0(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.JCNoType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type cloneWithMetadata_1(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isCompound()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getAnnotationMirrors()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeKind;", "public")]
		public Dova.JDK.javax.lang.model.type.TypeKind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeKind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$UnknownType;", "public static")]
	public partial class UnknownType
		: Dova.JDK.com.sun.tools.javac.code.Type
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UnknownType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$UnknownType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/code/TypeTag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_0", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$UnknownType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_1", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPartial", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationMirrors", "()Ljava/util/List;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UnknownType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public UnknownType() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$UnknownType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.javax.lang.model.type.TypeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/TypeTag;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.TypeTag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeTag>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$UnknownType;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.UnknownType cloneWithMetadata_0(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.UnknownType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type cloneWithMetadata_1(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPartial()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getAnnotationMirrors()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$ErrorType;", "public static")]
	public partial class ErrorType
		: Dova.JDK.com.sun.tools.javac.code.Type.ClassType
		, Dova.JDK.javax.lang.model.type.ErrorType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ErrorType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$ErrorType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "originalType", "Lcom/sun/tools/javac/code/Type;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/Type;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/TypeMetadata;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/code/Type;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInterface", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/code/TypeTag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "constType", "(Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingType_0", "()Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingType_1", "()Ljavax/lang/model/type/TypeMirror;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isErroneous", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_0", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$ClassType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_1", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$ErrorType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_2", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isReference", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNullOrReference", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPartial", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allparams", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCompound", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asSub", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isGenType", "(Lcom/sun/tools/javac/code/Type;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljavax/lang/model/type/TypeKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOriginalType", "()Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments_0", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments_1", "()Ljava/util/List;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "private")]
		public Dova.JDK.com.sun.tools.javac.code.Type originalType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ErrorType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/Type;)V", "public")]
		public ErrorType(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/TypeMetadata;)V", "private")]
		public ErrorType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg1, Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)V", "public")]
		public ErrorType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/code/Type;)V", "public")]
		public ErrorType(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$ErrorType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool isInterface()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type getReturnType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.javac.code.Type.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.javax.lang.model.type.TypeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/TypeTag;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.TypeTag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeTag>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type constType(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type getEnclosingType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeMirror;", "public volatile")]
		public Dova.JDK.javax.lang.model.type.TypeMirror getEnclosingType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isErroneous()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$ClassType;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type.ClassType cloneWithMetadata_0(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.ClassType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$ErrorType;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.ErrorType cloneWithMetadata_1(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.ErrorType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type cloneWithMetadata_2(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isReference()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isNullOrReference()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPartial()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List allparams()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isCompound()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type asSub(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "public")]
		public bool isGenType(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeKind;", "public")]
		public Dova.JDK.javax.lang.model.type.TypeKind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeKind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type getOriginalType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getTypeArguments_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getTypeArguments_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$BottomType;", "static")]
	public partial class BottomType
		: Dova.JDK.com.sun.tools.javac.code.Type
		, Dova.JDK.javax.lang.model.type.NullType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BottomType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$BottomType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stringValue", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/code/TypeTag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "constType", "(Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_0", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$BottomType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_1", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNullOrReference", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCompound", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationMirrors", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljavax/lang/model/type/TypeKind;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BottomType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public BottomType() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$BottomType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.javax.lang.model.type.TypeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String stringValue()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/TypeTag;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.TypeTag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeTag>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type constType(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$BottomType;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.BottomType cloneWithMetadata_0(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.BottomType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type cloneWithMetadata_1(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isNullOrReference()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isCompound()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getAnnotationMirrors()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeKind;", "public")]
		public Dova.JDK.javax.lang.model.type.TypeKind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeKind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$JCVoidType;", "public static")]
	public partial class JCVoidType
		: Dova.JDK.com.sun.tools.javac.code.Type
		, Dova.JDK.javax.lang.model.type.NoType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCVoidType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$JCVoidType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/code/TypeTag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_0", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_1", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$JCVoidType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitiveOrVoid", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCompound", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationMirrors", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljavax/lang/model/type/TypeKind;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCVoidType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public JCVoidType() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$JCVoidType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.javax.lang.model.type.TypeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/TypeTag;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.TypeTag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeTag>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type cloneWithMetadata_0(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$JCVoidType;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.JCVoidType cloneWithMetadata_1(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.JCVoidType>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPrimitiveOrVoid()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isCompound()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getAnnotationMirrors()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeKind;", "public")]
		public Dova.JDK.javax.lang.model.type.TypeKind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeKind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$UndetVar;", "public static")]
	public partial class UndetVar
		: Dova.JDK.com.sun.tools.javac.code.Type.DelegatedType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UndetVar()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$UndetVar;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "incorporationActions", "Ljava/util/ArrayDeque;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bounds", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inst", "Lcom/sun/tools/javac/code/Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaredCount", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listener", "Lcom/sun/tools/javac/code/Type$UndetVar$UndetVarListener;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kind", "Lcom/sun/tools/javac/code/Type$UndetVar$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toTypeVarMap", "Lcom/sun/tools/javac/code/Types$TypeMapping;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Type$TypeVar;Lcom/sun/tools/javac/code/Type$UndetVar$UndetVarListener;Lcom/sun/tools/javac/code/Types;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "([Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debugString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/code/Types;)Lcom/sun/tools/javac/code/Type$UndetVar;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "baseType", "()Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_0", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$UndetVar;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_1", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPartial", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInst", "()Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dupTo", "(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Types;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInst", "(Lcom/sun/tools/javac/code/Type;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "substBounds", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Types;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredBounds", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCaptured", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addBound", "(Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Types;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addBound", "(Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Types;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "notifyBoundChange", "(Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/code/Type;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setThrow", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isThrows", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBounds", "(Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/util/List;)V"));
		}

		[JniSignatureAttribute("Ljava/util/ArrayDeque;", "public")]
		public Dova.JDK.java.util.ArrayDeque incorporationActions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayDeque>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "protected")]
		public Dova.JDK.java.util.Map bounds_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "private")]
		public Dova.JDK.com.sun.tools.javac.code.Type inst_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "public")]
		public int declaredCount_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$UndetVar$UndetVarListener;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.UndetVarListener listener_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.UndetVarListener>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$UndetVar$Kind;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.Kind kind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$TypeMapping;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Types.TypeMapping toTypeVarMap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.TypeMapping>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UndetVar(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Lcom/sun/tools/javac/code/Type$UndetVar$UndetVarListener;Lcom/sun/tools/javac/code/Types;)V", "public")]
		public UndetVar(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.UndetVarListener arg1, Dova.JDK.com.sun.tools.javac.code.Types arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$UndetVar;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("([Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)Lcom/sun/tools/javac/util/List;", "public transient")]
		public Dova.JDK.com.sun.tools.javac.util.List getBounds(JavaArray<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.javac.code.Type.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String debugString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;)Lcom/sun/tools/javac/code/Type$UndetVar;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.UndetVar dup(Dova.JDK.com.sun.tools.javac.code.Types arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type baseType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$UndetVar;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.UndetVar cloneWithMetadata_0(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type cloneWithMetadata_1(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPartial()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type getInst()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Types;)V", "public")]
		public void dupTo(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0, Dova.JDK.com.sun.tools.javac.code.Types arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)V", "public")]
		public void setInst(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Types;)V", "public")]
		public void substBounds(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.code.Types arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getDeclaredBounds()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Z", "public final")]
		public bool isCaptured()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Types;Z)V", "private")]
		public void addBound(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Types arg2, bool arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Types;)V", "public final")]
		public void addBound(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Types arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/code/Type;Z)V", "private")]
		public void notifyBoundChange(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, bool arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()V", "public")]
		public void setThrow()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18]);
		}

		[JniSignatureAttribute("()Z", "public final")]
		public bool isThrows()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/util/List;)V", "public")]
		public void setBounds(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$UndetVar$UndetVarListener;", "public abstract static interface")]
		public partial interface UndetVarListener
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static UndetVarListener()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$UndetVar$UndetVarListener;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "varInstantiated", "(Lcom/sun/tools/javac/code/Type$UndetVar;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "varBoundChanged", "(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/code/Type;Z)V"));
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;)V", "public")]
			void varInstantiated(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/code/Type;Z)V", "public abstract")]
			void varBoundChanged(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, bool arg3)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$UndetVar$Kind;", "static final")]
		public partial class Kind
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Kind()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$UndetVar$Kind;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NORMAL", "Lcom/sun/tools/javac/code/Type$UndetVar$Kind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CAPTURED", "Lcom/sun/tools/javac/code/Type$UndetVar$Kind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THROWS", "Lcom/sun/tools/javac/code/Type$UndetVar$Kind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/code/Type$UndetVar$Kind;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/code/Type$UndetVar$Kind;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/code/Type$UndetVar$Kind;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/code/Type$UndetVar$Kind;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$UndetVar$Kind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.Kind NORMAL_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.Kind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$UndetVar$Kind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.Kind CAPTURED_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.Kind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$UndetVar$Kind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.Kind THROWS_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.Kind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lcom/sun/tools/javac/code/Type$UndetVar$Kind;", "private static final")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.Kind> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.Kind>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Kind(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public Kind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$UndetVar$Kind;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Type$UndetVar$Kind;", "public static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.Kind> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.Kind>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/code/Type$UndetVar$Kind;", "public static")]
			public static Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.Kind valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.Kind>(ret);
			}

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Type$UndetVar$Kind;", "private static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.Kind> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.Kind>>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;", "public abstract static")]
		public partial class InferenceBound
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static InferenceBound()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOWER", "Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EQ", "Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UPPER", "Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complement", "()Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lessThan", "(Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)Z"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound LOWER_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound EQ_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound UPPER_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;", "private static final")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public InferenceBound(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public InferenceBound(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;", "public static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;", "public static")]
			public static Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound>(ret);
			}

			[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;", "public abstract")]
			public Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound complement()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound>(ret);
			}

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;", "private static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound>>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)Z", "public")]
			public bool lessThan(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$ForAll;", "public static")]
	public partial class ForAll
		: Dova.JDK.com.sun.tools.javac.code.Type.DelegatedType
		, Dova.JDK.javax.lang.model.type.ExecutableType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForAll()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$ForAll;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tvars", "Lcom/sun/tools/javac/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Lcom/sun/tools/javac/code/Type;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Ljavax/lang/model/type/TypeMirror;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterTypes", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asMethodType", "()Lcom/sun/tools/javac/code/Type$MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isErroneous", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_0", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$ForAll;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_1", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariables_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariables_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReceiverType", "()Ljavax/lang/model/type/TypeMirror;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThrownTypes", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljavax/lang/model/type/TypeKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments", "()Lcom/sun/tools/javac/util/List;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List tvars_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForAll(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type;)V", "public")]
		public ForAll(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$ForAll;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "public")]
		public bool contains(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeMirror;", "public volatile")]
		public Dova.JDK.javax.lang.model.type.TypeMirror getReturnType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getParameterTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.javac.code.Type.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.javax.lang.model.type.TypeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void complete()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type$MethodType;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.MethodType asMethodType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.MethodType>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isErroneous()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$ForAll;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.ForAll cloneWithMetadata_0(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.ForAll>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type cloneWithMetadata_1(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getTypeVariables_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getTypeVariables_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeMirror;", "public volatile")]
		public Dova.JDK.javax.lang.model.type.TypeMirror getReceiverType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getThrownTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeKind;", "public")]
		public Dova.JDK.javax.lang.model.type.TypeKind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeKind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getTypeArguments()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$DelegatedType;", "public abstract static")]
	public partial class DelegatedType
		: Dova.JDK.com.sun.tools.javac.code.Type
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DelegatedType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$DelegatedType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "qtype", "Lcom/sun/tools/javac/code/Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tag", "Lcom/sun/tools/javac/code/TypeTag;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/TypeTag;Lcom/sun/tools/javac/code/Type;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/TypeTag;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/TypeMetadata;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterTypes", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/code/TypeTag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingType", "()Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBound", "()Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isErroneous", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allparams", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationMirrors", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReceiverType", "()Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThrownTypes", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments", "()Lcom/sun/tools/javac/util/List;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type qtype_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/TypeTag;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.TypeTag tag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DelegatedType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeTag;Lcom/sun/tools/javac/code/Type;)V", "public")]
		public DelegatedType(Dova.JDK.com.sun.tools.javac.code.TypeTag arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeTag;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/TypeMetadata;)V", "public")]
		public DelegatedType(Dova.JDK.com.sun.tools.javac.code.TypeTag arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$DelegatedType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type getReturnType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getParameterTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/TypeTag;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.TypeTag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeTag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type getEnclosingType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type getUpperBound()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isErroneous()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List allparams()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getAnnotationMirrors()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type getReceiverType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getThrownTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getTypeArguments()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$CapturedType;", "public static")]
	public partial class CapturedType
		: Dova.JDK.com.sun.tools.javac.code.Type.TypeVar
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CapturedType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$CapturedType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "wildcard", "Lcom/sun/tools/javac/code/Type$WildcardType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type$WildcardType;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type$WildcardType;Lcom/sun/tools/javac/code/TypeMetadata;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_0", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$TypeVar;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_1", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_2", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$CapturedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCaptured", "()Z"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$WildcardType;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.WildcardType wildcard_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.WildcardType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CapturedType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type$WildcardType;)V", "public")]
		public CapturedType(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.com.sun.tools.javac.code.Type arg3, Dova.JDK.com.sun.tools.javac.code.Type.WildcardType arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type$WildcardType;Lcom/sun/tools/javac/code/TypeMetadata;)V", "public")]
		public CapturedType(Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.com.sun.tools.javac.code.Type arg3, Dova.JDK.com.sun.tools.javac.code.Type.WildcardType arg4, Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$CapturedType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.javac.code.Type.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$TypeVar;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type.TypeVar cloneWithMetadata_0(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.TypeVar>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type cloneWithMetadata_1(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$CapturedType;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.CapturedType cloneWithMetadata_2(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.CapturedType>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isCaptured()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$TypeVar;", "public static")]
	public partial class TypeVar
		: Dova.JDK.com.sun.tools.javac.code.Type
		, Dova.JDK.javax.lang.model.type.TypeVariable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypeVar()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$TypeVar;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_bound", "Lcom/sun/tools/javac/code/Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lower", "Lcom/sun/tools/javac/code/Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rank_field", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/TypeMetadata;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/code/TypeTag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBound_0", "()Ljavax/lang/model/type/TypeMirror;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBound_1", "()Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_0", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_1", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$TypeVar;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isReference", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNullOrReference", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLowerBound_0", "()Ljavax/lang/model/type/TypeMirror;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLowerBound_1", "()Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asElement", "()Ljavax/lang/model/element/Element;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationMirrors", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCaptured", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setUpperBound", "(Lcom/sun/tools/javac/code/Type;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljavax/lang/model/type/TypeKind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "private")]
		public Dova.JDK.com.sun.tools.javac.code.Type _bound_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type lower_Property
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

		[JniSignatureAttribute("I", "")]
		public int rank_field_Property
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
		public TypeVar(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/TypeMetadata;)V", "public")]
		public TypeVar(Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)V", "public")]
		public TypeVar(Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Type;)V", "public")]
		public TypeVar(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$TypeVar;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.javax.lang.model.type.TypeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.javac.code.Type.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/TypeTag;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.TypeTag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeTag>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeMirror;", "public volatile")]
		public Dova.JDK.javax.lang.model.type.TypeMirror getUpperBound_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type getUpperBound_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type cloneWithMetadata_0(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$TypeVar;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.TypeVar cloneWithMetadata_1(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.TypeVar>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isReference()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isNullOrReference()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeMirror;", "public volatile")]
		public Dova.JDK.javax.lang.model.type.TypeMirror getLowerBound_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type getLowerBound_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/element/Element;", "public volatile")]
		public Dova.JDK.javax.lang.model.element.Element asElement()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Element>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getAnnotationMirrors()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isCaptured()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)V", "public")]
		public void setUpperBound(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeKind;", "public")]
		public Dova.JDK.javax.lang.model.type.TypeKind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeKind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$ModuleType;", "public static")]
	public partial class ModuleType
		: Dova.JDK.com.sun.tools.javac.code.Type
		, Dova.JDK.javax.lang.model.type.NoType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ModuleType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$ModuleType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Symbol$ModuleSymbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/code/TypeTag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_0", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_1", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$ModuleType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotatedType_0", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotatedType_1", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type$ModuleType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationMirrors", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljavax/lang/model/type/TypeKind;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ModuleType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ModuleSymbol;)V", "")]
		public ModuleType(Dova.JDK.com.sun.tools.javac.code.Symbol.ModuleSymbol arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$ModuleType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.javac.code.Type.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.javax.lang.model.type.TypeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/TypeTag;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.TypeTag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeTag>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type cloneWithMetadata_0(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$ModuleType;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.ModuleType cloneWithMetadata_1(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.ModuleType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type annotatedType_0(Dova.JDK.com.sun.tools.javac.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type$ModuleType;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.ModuleType annotatedType_1(Dova.JDK.com.sun.tools.javac.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.ModuleType>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getAnnotationMirrors()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeKind;", "public")]
		public Dova.JDK.javax.lang.model.type.TypeKind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeKind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$PackageType;", "public static")]
	public partial class PackageType
		: Dova.JDK.com.sun.tools.javac.code.Type
		, Dova.JDK.javax.lang.model.type.NoType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PackageType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$PackageType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Symbol$PackageSymbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/code/TypeTag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_0", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_1", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$PackageType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationMirrors", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljavax/lang/model/type/TypeKind;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PackageType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$PackageSymbol;)V", "")]
		public PackageType(Dova.JDK.com.sun.tools.javac.code.Symbol.PackageSymbol arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$PackageType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.javax.lang.model.type.TypeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.javac.code.Type.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/TypeTag;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.TypeTag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeTag>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type cloneWithMetadata_0(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$PackageType;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.PackageType cloneWithMetadata_1(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.PackageType>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getAnnotationMirrors()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeKind;", "public")]
		public Dova.JDK.javax.lang.model.type.TypeKind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeKind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$MethodType;", "public static")]
	public partial class MethodType
		: Dova.JDK.com.sun.tools.javac.code.Type
		, Dova.JDK.javax.lang.model.type.ExecutableType
		, Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MethodType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$MethodType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argtypes", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "restype", "Lcom/sun/tools/javac/code/Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thrown", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recvtype", "Lcom/sun/tools/javac/code/Type;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Lcom/sun/tools/javac/code/Type;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType_0", "()Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType_1", "()Ljavax/lang/model/type/TypeMirror;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterTypes_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterTypes_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/code/TypeTag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asMethodType", "()Lcom/sun/tools/javac/code/Type$MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "poolTag", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isErroneous", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_0", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_1", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariables_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariables_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asElement", "()Lcom/sun/tools/javac/code/Symbol$TypeSymbol;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationMirrors", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReceiverType_0", "()Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReceiverType_1", "()Ljavax/lang/model/type/TypeMirror;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThrownTypes_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThrownTypes_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljavax/lang/model/type/TypeKind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List argtypes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type restype_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List thrown_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type recvtype_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MethodType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)V", "public")]
		public MethodType(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.List arg2, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$MethodType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "public")]
		public bool contains(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type getReturnType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeMirror;", "public volatile")]
		public Dova.JDK.javax.lang.model.type.TypeMirror getReturnType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getParameterTypes_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getParameterTypes_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.javac.code.Type.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.javax.lang.model.type.TypeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void complete()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/TypeTag;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.TypeTag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeTag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type$MethodType;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.MethodType asMethodType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.MethodType>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int poolTag()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isErroneous()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type cloneWithMetadata_0(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$MethodType;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.MethodType cloneWithMetadata_1(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.MethodType>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getTypeVariables_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getTypeVariables_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Symbol$TypeSymbol;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol asElement()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getAnnotationMirrors()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type getReceiverType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeMirror;", "public volatile")]
		public Dova.JDK.javax.lang.model.type.TypeMirror getReceiverType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getThrownTypes_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getThrownTypes_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeKind;", "public")]
		public Dova.JDK.javax.lang.model.type.TypeKind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeKind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$IntersectionClassType;", "public static")]
	public partial class IntersectionClassType
		: Dova.JDK.com.sun.tools.javac.code.Type.ClassType
		, Dova.JDK.javax.lang.model.type.IntersectionType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IntersectionClassType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$IntersectionClassType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allInterfaces", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_0", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$ClassType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_1", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_2", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$IntersectionClassType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCompound", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isIntersection", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExplicitComponents", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljavax/lang/model/type/TypeKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponents", "()Lcom/sun/tools/javac/util/List;"));
		}

		[JniSignatureAttribute("Z", "public")]
		public bool allInterfaces_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IntersectionClassType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Z)V", "public")]
		public IntersectionClassType(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$IntersectionClassType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getBounds()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.javax.lang.model.type.TypeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$ClassType;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type.ClassType cloneWithMetadata_0(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.ClassType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type cloneWithMetadata_1(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$IntersectionClassType;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.IntersectionClassType cloneWithMetadata_2(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.IntersectionClassType>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isCompound()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isIntersection()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getExplicitComponents()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeKind;", "public")]
		public Dova.JDK.javax.lang.model.type.TypeKind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeKind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getComponents()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$UnionClassType;", "public static")]
	public partial class UnionClassType
		: Dova.JDK.com.sun.tools.javac.code.Type.ClassType
		, Dova.JDK.javax.lang.model.type.UnionType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UnionClassType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$UnionClassType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "alternatives_field", "Lcom/sun/tools/javac/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Type$ClassType;Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isUnion", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_0", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_1", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$ClassType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_2", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$UnionClassType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCompound", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAlternativeTypes", "()Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAlternatives", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljavax/lang/model/type/TypeKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLub", "()Lcom/sun/tools/javac/code/Type;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "final")]
		public Dova.JDK.com.sun.tools.javac.util.List alternatives_field_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UnionClassType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Lcom/sun/tools/javac/util/List;)V", "public")]
		public UnionClassType(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.com.sun.tools.javac.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$UnionClassType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.javax.lang.model.type.TypeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isUnion()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type cloneWithMetadata_0(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$ClassType;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type.ClassType cloneWithMetadata_1(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.ClassType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$UnionClassType;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.UnionClassType cloneWithMetadata_2(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.UnionClassType>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isCompound()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable getAlternativeTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getAlternatives()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeKind;", "public")]
		public Dova.JDK.javax.lang.model.type.TypeKind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeKind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type getLub()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$ErasedClassType;", "public static")]
	public partial class ErasedClassType
		: Dova.JDK.com.sun.tools.javac.code.Type.ClassType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ErasedClassType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$ErasedClassType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/TypeMetadata;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasErasedSupertypes", "()Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ErasedClassType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/TypeMetadata;)V", "public")]
		public ErasedClassType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg1, Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$ErasedClassType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool hasErasedSupertypes()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$ClassType;", "public static")]
	public partial class ClassType
		: Dova.JDK.com.sun.tools.javac.code.Type
		, Dova.JDK.javax.lang.model.type.DeclaredType
		, Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant
		, Dova.JDK.javax.lang.model.type.ErrorType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ClassType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$ClassType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outer_field", "Lcom/sun/tools/javac/code/Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typarams_field", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allparams_field", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "supertype_field", "Lcom/sun/tools/javac/code/Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interfaces_field", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "all_interfaces_field", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rank_field", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/TypeMetadata;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "className", "(Lcom/sun/tools/javac/code/Symbol;Z)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Lcom/sun/tools/javac/code/Type;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/code/TypeTag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "poolTag", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "constType", "(Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingType_0", "()Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingType_1", "()Ljavax/lang/model/type/TypeMirror;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isParameterized", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isErroneous", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEnclosingType", "(Lcom/sun/tools/javac/code/Type;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_0", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$ClassType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_1", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isReference", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNullOrReference", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allparams", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRaw", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asElement", "()Ljavax/lang/model/element/Element;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationMirrors", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasErasedSupertypes", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljavax/lang/model/type/TypeKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments_0", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments_1", "()Ljava/util/List;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "private")]
		public Dova.JDK.com.sun.tools.javac.code.Type outer_field_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List typarams_field_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List allparams_field_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type supertype_field_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List interfaces_field_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List all_interfaces_field_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int rank_field_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ClassType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)V", "public")]
		public ClassType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/TypeMetadata;)V", "public")]
		public ClassType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg2, Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$ClassType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Z)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String className(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "public")]
		public bool contains(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.javax.lang.model.type.TypeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.javac.code.Type.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void complete()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/TypeTag;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.TypeTag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeTag>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int poolTag()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type constType(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type getEnclosingType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeMirror;", "public volatile")]
		public Dova.JDK.javax.lang.model.type.TypeMirror getEnclosingType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isParameterized()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isErroneous()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)V", "public")]
		public void setEnclosingType(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$ClassType;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.ClassType cloneWithMetadata_0(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.ClassType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type cloneWithMetadata_1(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isReference()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isNullOrReference()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List allparams()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isRaw()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19]);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/lang/model/element/Element;", "public volatile")]
		public Dova.JDK.javax.lang.model.element.Element asElement()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Element>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getAnnotationMirrors()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasErasedSupertypes()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22]);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeKind;", "public")]
		public Dova.JDK.javax.lang.model.type.TypeKind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeKind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getTypeArguments_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getTypeArguments_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$WildcardType;", "public static")]
	public partial class WildcardType
		: Dova.JDK.com.sun.tools.javac.code.Type
		, Dova.JDK.javax.lang.model.type.WildcardType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WildcardType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$WildcardType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lcom/sun/tools/javac/code/Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kind", "Lcom/sun/tools/javac/code/BoundKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bound", "Lcom/sun/tools/javac/code/Type$TypeVar;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isPrintingBound", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/BoundKind;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/Type$TypeVar;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/BoundKind;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/TypeMetadata;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/BoundKind;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/BoundKind;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/Type$TypeVar;Lcom/sun/tools/javac/code/TypeMetadata;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Lcom/sun/tools/javac/code/Type;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/code/TypeTag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_0", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$WildcardType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_1", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isReference", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNullOrReference", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSuperBound", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExtendsBound", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isUnbound", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withTypeVar", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationMirrors", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExtendsBound_0", "()Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExtendsBound_1", "()Ljavax/lang/model/type/TypeMirror;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperBound_0", "()Ljavax/lang/model/type/TypeMirror;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperBound_1", "()Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljavax/lang/model/type/TypeKind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/BoundKind;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.BoundKind kind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.BoundKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$TypeVar;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.TypeVar bound_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.TypeVar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool isPrintingBound_Property
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
		public WildcardType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/BoundKind;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/Type$TypeVar;)V", "public")]
		public WildcardType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.BoundKind arg1, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg2, Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/BoundKind;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/TypeMetadata;)V", "public")]
		public WildcardType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.BoundKind arg1, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg2, Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/BoundKind;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)V", "public")]
		public WildcardType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.BoundKind arg1, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/BoundKind;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/Type$TypeVar;Lcom/sun/tools/javac/code/TypeMetadata;)V", "public")]
		public WildcardType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.BoundKind arg1, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg2, Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg3, Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$WildcardType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "public")]
		public bool contains(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.javax.lang.model.type.TypeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.javac.code.Type.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/TypeTag;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.TypeTag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeTag>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$WildcardType;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.WildcardType cloneWithMetadata_0(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.WildcardType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type cloneWithMetadata_1(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isReference()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isNullOrReference()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isSuperBound()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isExtendsBound()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isUnbound()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type withTypeVar(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getAnnotationMirrors()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type getExtendsBound_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeMirror;", "public volatile")]
		public Dova.JDK.javax.lang.model.type.TypeMirror getExtendsBound_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeMirror;", "public volatile")]
		public Dova.JDK.javax.lang.model.type.TypeMirror getSuperBound_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type getSuperBound_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeKind;", "public")]
		public Dova.JDK.javax.lang.model.type.TypeKind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeKind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$JCPrimitiveType;", "public static")]
	public partial class JCPrimitiveType
		: Dova.JDK.com.sun.tools.javac.code.Type
		, Dova.JDK.javax.lang.model.type.PrimitiveType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCPrimitiveType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$JCPrimitiveType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tag", "Lcom/sun/tools/javac/code/TypeTag;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/TypeTag;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/TypeTag;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/TypeMetadata;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitive", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stringValue", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/code/TypeTag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNumeric", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isIntegral", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "constType", "(Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_0", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$JCPrimitiveType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithMetadata_1", "(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitiveOrVoid", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFalse", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTrue", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationMirrors", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljavax/lang/model/type/TypeKind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/TypeTag;", "")]
		public Dova.JDK.com.sun.tools.javac.code.TypeTag tag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCPrimitiveType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeTag;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)V", "public")]
		public JCPrimitiveType(Dova.JDK.com.sun.tools.javac.code.TypeTag arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeTag;Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/code/TypeMetadata;)V", "private")]
		public JCPrimitiveType(Dova.JDK.com.sun.tools.javac.code.TypeTag arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg1, Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$JCPrimitiveType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool isPrimitive()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/TypeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.javax.lang.model.type.TypeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String stringValue()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/TypeTag;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.TypeTag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeTag>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isNumeric()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isIntegral()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type constType(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type$JCPrimitiveType;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.JCPrimitiveType cloneWithMetadata_0(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.JCPrimitiveType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeMetadata;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type cloneWithMetadata_1(Dova.JDK.com.sun.tools.javac.code.TypeMetadata arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPrimitiveOrVoid()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isFalse()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isTrue()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getAnnotationMirrors()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeKind;", "public")]
		public Dova.JDK.javax.lang.model.type.TypeKind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeKind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$StructuralTypeMapping;", "public abstract static")]
	public partial class StructuralTypeMapping
		: Dova.JDK.com.sun.tools.javac.code.Types.TypeMapping
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StructuralTypeMapping()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Type$StructuralTypeMapping;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType_0", "(Lcom/sun/tools/javac/code/Type$ArrayType;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType_1", "(Lcom/sun/tools/javac/code/Type$ArrayType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForAll_0", "(Lcom/sun/tools/javac/code/Type$ForAll;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForAll_1", "(Lcom/sun/tools/javac/code/Type$ForAll;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType_0", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType_1", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcardType_0", "(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcardType_1", "(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodType_0", "(Lcom/sun/tools/javac/code/Type$MethodType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodType_1", "(Lcom/sun/tools/javac/code/Type$MethodType;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StructuralTypeMapping(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public StructuralTypeMapping() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Type$StructuralTypeMapping;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ArrayType;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitArrayType_0(Dova.JDK.com.sun.tools.javac.code.Type.ArrayType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ArrayType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitArrayType_1(Dova.JDK.com.sun.tools.javac.code.Type.ArrayType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ForAll;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitForAll_0(Dova.JDK.com.sun.tools.javac.code.Type.ForAll arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ForAll;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitForAll_1(Dova.JDK.com.sun.tools.javac.code.Type.ForAll arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitClassType_0(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitClassType_1(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitWildcardType_0(Dova.JDK.com.sun.tools.javac.code.Type.WildcardType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$WildcardType;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitWildcardType_1(Dova.JDK.com.sun.tools.javac.code.Type.WildcardType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$MethodType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitMethodType_0(Dova.JDK.com.sun.tools.javac.code.Type.MethodType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$MethodType;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitMethodType_1(Dova.JDK.com.sun.tools.javac.code.Type.MethodType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}
	}
}
