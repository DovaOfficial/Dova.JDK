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

namespace Dova.JDK.java.lang;

[JniSignatureAttribute("Ljava/lang/Class;", "public final")]
public partial class Class
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Serializable
	, Dova.JDK.java.lang.reflect.GenericDeclaration
	, Dova.JDK.java.lang.reflect.Type
	, Dova.JDK.java.lang.reflect.AnnotatedElement
	, Dova.JDK.java.lang.invoke.TypeDescriptor.OfField
	, Dova.JDK.java.lang.constant.Constable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Class()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/Class;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANNOTATION", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENUM", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SYNTHETIC", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cachedConstructor", "Ljava/lang/reflect/Constructor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "module", "Ljava/lang/Module;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "packageName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "componentType", "Ljava/lang/Class;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "allPermDomain", "Ljava/security/ProtectionDomain;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reflectionData", "Ljava/lang/ref/SoftReference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classRedefinedCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericInfo", "Lsun/reflect/generics/repository/ClassRepository;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_CLASS_ARRAY", "[Ljava/lang/Class;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialPersistentFields", "[Ljava/io/ObjectStreamField;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "reflectionFactory", "Ljdk/internal/reflect/ReflectionFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enumConstants", "[Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enumConstantDirectory", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationData", "Ljava/lang/Class$AnnotationData;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationType", "Lsun/reflect/annotation/AnnotationType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classValueMap", "Ljava/lang/ClassValue$ClassValueMap;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkPackageAccess", "(Ljava/lang/SecurityManager;Ljava/lang/ClassLoader;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forName", "(Ljava/lang/String;ZLjava/lang/ClassLoader;Ljava/lang/Class;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forName", "(Ljava/lang/Module;Ljava/lang/String;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forName", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forName", "(Ljava/lang/Module;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forName", "(Ljava/lang/String;ZLjava/lang/ClassLoader;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forName", "(Ljava/lang/String;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forName0", "(Ljava/lang/String;ZLjava/lang/ClassLoader;Ljava/lang/Class;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModule", "()Ljava/lang/Module;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProtectionDomain", "()Ljava/security/ProtectionDomain;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignableFrom", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInstance", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInterface", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArray", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitive", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isHidden", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperclass", "()Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cast", "(Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentType_0", "()Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentType_1", "()Ljava/lang/invoke/TypeDescriptor$OfField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoader0", "()Ljava/lang/ClassLoader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "describeConstable", "()Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType", "()Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnnotation", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnum", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRecord", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoader", "()Ljava/lang/ClassLoader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkMemberAccess", "(Ljava/lang/SecurityManager;ILjava/lang/Class;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getReflectionFactory", "()Ljdk/internal/reflect/ReflectionFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConstructor0", "([Ljava/lang/Class;I)Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newInstance", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initClassName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericInfo", "()Lsun/reflect/generics/repository/ClassRepository;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "elementType", "()Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "(Z)[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "()[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reflectionData", "()Ljava/lang/Class$ReflectionData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces0", "()[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingMethodInfo", "()Ljava/lang/Class$EnclosingMethodInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFactory", "()Lsun/reflect/generics/factory/GenericsFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toClass", "(Ljava/lang/reflect/Type;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingClass", "()Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "privateGetDeclaredMethods", "(Z)[Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "arrayContentsEq", "([Ljava/lang/Object;[Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingMethod0", "()[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "privateGetDeclaredConstructors", "(Z)[Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringClass0", "()Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSimpleName0", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSimpleName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSimpleBinaryName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCanonicalName0", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCanonicalName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLocalOrAnonymousClass", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSimpleBinaryName0", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTopLevelClass", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasEnclosingMethodInfo", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "privateGetPublicFields", "()[Ljava/lang/reflect/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyFields", "([Ljava/lang/reflect/Field;)[Ljava/lang/reflect/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "privateGetPublicMethods", "()[Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyMethods", "([Ljava/lang/reflect/Method;)[Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyConstructors", "([Ljava/lang/reflect/Constructor;)[Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getField0", "(Ljava/lang/String;)Ljava/lang/reflect/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethod0", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "methodToString", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredClasses0", "()[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "privateGetDeclaredFields", "(Z)[Ljava/lang/reflect/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponents0", "()[Ljava/lang/reflect/RecordComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "searchFields", "([Ljava/lang/reflect/Field;Ljava/lang/String;)Ljava/lang/reflect/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "searchMethods", "([Ljava/lang/reflect/Method;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveName", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isOpenToCaller", "(Ljava/lang/String;Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResource", "(Ljava/lang/String;)Ljava/net/URL;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "protectionDomain", "()Ljava/security/ProtectionDomain;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProtectionDomain0", "()Ljava/security/ProtectionDomain;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackageName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newReflectionData", "(Ljava/lang/ref/SoftReference;I)Ljava/lang/Class$ReflectionData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericSignature0", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getExecutableTypeAnnotationBytes", "(Ljava/lang/reflect/Executable;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredFields0", "(Z)[Ljava/lang/reflect/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addAll", "(Ljava/util/Collection;[Ljava/lang/reflect/Field;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredConstructors0", "(Z)[Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethods0", "(Z)[Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodsRecursive", "(Ljava/lang/String;[Ljava/lang/Class;Z)Ljava/lang/PublicMethods$MethodList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "desiredAssertionStatus0", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "desiredAssertionStatus", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRecord0", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnumConstantsShared", "()[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "enumConstantDirectory", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cannotCastMsg", "(Ljava/lang/Object;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotationData", "()Ljava/lang/Class$AnnotationData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnnotationPresent", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createAnnotationData", "(I)Ljava/lang/Class$AnnotationData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRawAnnotations", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConstantPool", "()Ljdk/internal/reflect/ConstantPool;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "casAnnotationType", "(Lsun/reflect/annotation/AnnotationType;Lsun/reflect/annotation/AnnotationType;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRawTypeAnnotations", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestHost0", "()Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestHost", "()Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestMembers0", "()[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "descriptorString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPermittedSubclasses0", "()[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkPackageAccessForPermittedSubclasses", "(Ljava/lang/SecurityManager;Ljava/lang/ClassLoader;[Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPermittedSubclasses", "()[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "arrayType_0", "()Ljava/lang/invoke/TypeDescriptor$OfField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "arrayType_1", "()Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDirectSubType", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "registerNatives", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toGenericString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "typeVarBounds", "(Ljava/lang/reflect/TypeVariable;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSynthetic", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassData", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericSuperclass", "()Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackage", "()Ljava/lang/Package;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericInterfaces", "()[Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSigners", "()[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSigners", "([Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingMethod", "()Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingConstructor", "()Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringClass", "()Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnonymousClass", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLocalClass", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isMemberClass", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClasses", "()[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFields", "()[Ljava/lang/reflect/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethods", "()[Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConstructors", "()[Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredClasses", "()[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredFields", "()[Ljava/lang/reflect/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponents", "()[Ljava/lang/reflect/RecordComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethods", "()[Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredConstructors", "()[Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredPublicMethods", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPrimitiveClass", "(Ljava/lang/String;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnumConstants", "()[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asSubclass", "(Ljava/lang/Class;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationsByType", "(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations", "()[Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotationsByType", "(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationType", "()Lsun/reflect/annotation/AnnotationType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotationMap", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotatedSuperclass", "()Ljava/lang/reflect/AnnotatedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotatedInterfaces", "()[Ljava/lang/reflect/AnnotatedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNestmateOf", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestMembers", "()[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSealed", "()Z"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int ANNOTATION_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int ENUM_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int SYNTHETIC_Property
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

	[JniSignatureAttribute("Ljava/lang/reflect/Constructor;", "private transient volatile")]
	public Dova.JDK.java.lang.reflect.Constructor cachedConstructor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private transient")]
	public Dova.JDK.java.lang.String name_Property
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

	[JniSignatureAttribute("Ljava/lang/Module;", "private transient")]
	public Dova.JDK.java.lang.Module module_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Module>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private transient")]
	public Dova.JDK.java.lang.String packageName_Property
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

	[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
	public Dova.JDK.java.lang.Class componentType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/ProtectionDomain;", "private static")]
	public static Dova.JDK.java.security.ProtectionDomain allPermDomain_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.ProtectionDomain>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ref/SoftReference;", "private transient volatile")]
	public Dova.JDK.java.lang.@ref.SoftReference reflectionData_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.SoftReference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private transient volatile")]
	public int classRedefinedCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("Lsun/reflect/generics/repository/ClassRepository;", "private transient volatile")]
	public Dova.JDK.sun.reflect.generics.repository.ClassRepository genericInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.repository.ClassRepository>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/Class;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.Class> EMPTY_CLASS_ARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("[Ljava/io/ObjectStreamField;", "private static final")]
	public static JavaArray<Dova.JDK.java.io.ObjectStreamField> serialPersistentFields_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.io.ObjectStreamField>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/reflect/ReflectionFactory;", "private static")]
	public static Dova.JDK.jdk.@internal.reflect.ReflectionFactory reflectionFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ReflectionFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/Object;", "private transient volatile")]
	public JavaArray<Dova.JDK.java.lang.Object> enumConstants_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private transient volatile")]
	public Dova.JDK.java.util.Map enumConstantDirectory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Class$AnnotationData;", "private transient volatile")]
	public Dova.JDK.java.lang.Class.AnnotationData annotationData_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class.AnnotationData>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/reflect/annotation/AnnotationType;", "private transient volatile")]
	public Dova.JDK.sun.reflect.annotation.AnnotationType annotationType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.AnnotationType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ClassValue$ClassValueMap;", "transient")]
	public Dova.JDK.java.lang.ClassValue.ClassValueMap classValueMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassValue.ClassValueMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Class(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/Class;)V", "private")]
	public Class(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.Class arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/Class;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/SecurityManager;Ljava/lang/ClassLoader;Z)V", "private")]
	public void checkPackageAccess(Dova.JDK.java.lang.SecurityManager arg0, Dova.JDK.java.lang.ClassLoader arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ZLjava/lang/ClassLoader;Ljava/lang/Class;)Ljava/lang/Class;", "private static")]
	public static Dova.JDK.java.lang.Class forName(Dova.JDK.java.lang.String arg0, bool arg1, Dova.JDK.java.lang.ClassLoader arg2, Dova.JDK.java.lang.Class arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Module;Ljava/lang/String;)Ljava/lang/Class;", "public static")]
	public static Dova.JDK.java.lang.Class forName(Dova.JDK.java.lang.Module arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Class;", "private static")]
	public static Dova.JDK.java.lang.Class forName(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Module;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Class;", "private static")]
	public static Dova.JDK.java.lang.Class forName(Dova.JDK.java.lang.Module arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ZLjava/lang/ClassLoader;)Ljava/lang/Class;", "public static")]
	public static Dova.JDK.java.lang.Class forName(Dova.JDK.java.lang.String arg0, bool arg1, Dova.JDK.java.lang.ClassLoader arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Class;", "public static")]
	public static Dova.JDK.java.lang.Class forName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ZLjava/lang/ClassLoader;Ljava/lang/Class;)Ljava/lang/Class;", "private static native")]
	public static Dova.JDK.java.lang.Class forName0(Dova.JDK.java.lang.String arg0, bool arg1, Dova.JDK.java.lang.ClassLoader arg2, Dova.JDK.java.lang.Class arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Module;", "public")]
	public Dova.JDK.java.lang.Module getModule()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Module>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/ProtectionDomain;", "public")]
	public Dova.JDK.java.security.ProtectionDomain getProtectionDomain()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.ProtectionDomain>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public native")]
	public bool isAssignableFrom(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public native")]
	public bool isInstance(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public native")]
	public int getModifiers()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public native")]
	public bool isInterface()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public native")]
	public bool isArray()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public native")]
	public bool isPrimitive()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public native")]
	public bool isHidden()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "public native")]
	public Dova.JDK.java.lang.Class getSuperclass()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object cast(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class componentType_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/TypeDescriptor$OfField;", "public volatile")]
	public Dova.JDK.java.lang.invoke.TypeDescriptor.OfField componentType_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.TypeDescriptor.OfField>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/ClassLoader;", "")]
	public Dova.JDK.java.lang.ClassLoader getClassLoader0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Optional;", "public")]
	public Dova.JDK.java.util.Optional describeConstable()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class getComponentType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isAnnotation()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isEnum()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isRecord()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[28]);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/TypeVariable;", "public")]
	public JavaArray<Dova.JDK.java.lang.reflect.TypeVariable> getTypeParameters()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.TypeVariable>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/ClassLoader;", "public")]
	public Dova.JDK.java.lang.ClassLoader getClassLoader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/SecurityManager;ILjava/lang/Class;Z)V", "private")]
	public void checkMemberAccess(Dova.JDK.java.lang.SecurityManager arg0, int arg1, Dova.JDK.java.lang.Class arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Ljdk/internal/reflect/ReflectionFactory;", "private static")]
	public static Dova.JDK.jdk.@internal.reflect.ReflectionFactory getReflectionFactory()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ReflectionFactory>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Class;I)Ljava/lang/reflect/Constructor;", "private")]
	public Dova.JDK.java.lang.reflect.Constructor getConstructor0(JavaArray<Dova.JDK.java.lang.Class> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object newInstance()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private native")]
	public Dova.JDK.java.lang.String initClassName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/repository/ClassRepository;", "private")]
	public Dova.JDK.sun.reflect.generics.repository.ClassRepository getGenericInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.repository.ClassRepository>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "private")]
	public Dova.JDK.java.lang.Class elementType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Z)[Ljava/lang/Class;", "private")]
	public JavaArray<Dova.JDK.java.lang.Class> getInterfaces(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/Class;", "public")]
	public JavaArray<Dova.JDK.java.lang.Class> getInterfaces()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Class$ReflectionData;", "private")]
	public Dova.JDK.java.lang.Class.ReflectionData reflectionData()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class.ReflectionData>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/Class;", "private native")]
	public JavaArray<Dova.JDK.java.lang.Class> getInterfaces0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Class$EnclosingMethodInfo;", "private")]
	public Dova.JDK.java.lang.Class.EnclosingMethodInfo getEnclosingMethodInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class.EnclosingMethodInfo>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/factory/GenericsFactory;", "private")]
	public Dova.JDK.sun.reflect.generics.factory.GenericsFactory getFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.factory.GenericsFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Ljava/lang/Class;", "private static")]
	public static Dova.JDK.java.lang.Class toClass(Dova.JDK.java.lang.reflect.Type arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class getEnclosingClass()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Z)[Ljava/lang/reflect/Method;", "private")]
	public JavaArray<Dova.JDK.java.lang.reflect.Method> privateGetDeclaredMethods(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Method>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;[Ljava/lang/Object;)Z", "private static")]
	public static bool arrayContentsEq(JavaArray<Dova.JDK.java.lang.Object> arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[47], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/lang/Object;", "private native")]
	public JavaArray<Dova.JDK.java.lang.Object> getEnclosingMethod0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("(Z)[Ljava/lang/reflect/Constructor;", "private")]
	public JavaArray<Dova.JDK.java.lang.reflect.Constructor> privateGetDeclaredConstructors(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Constructor>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "private native")]
	public Dova.JDK.java.lang.Class getDeclaringClass0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getSimpleName0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getSimpleName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getSimpleBinaryName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getCanonicalName0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getCanonicalName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool isLocalOrAnonymousClass()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[56]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private native")]
	public Dova.JDK.java.lang.String getSimpleBinaryName0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool isTopLevelClass()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[58]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool hasEnclosingMethodInfo()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[59]);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/Field;", "private")]
	public JavaArray<Dova.JDK.java.lang.reflect.Field> privateGetPublicFields()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Field>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/reflect/Field;)[Ljava/lang/reflect/Field;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.reflect.Field> copyFields(JavaArray<Dova.JDK.java.lang.reflect.Field> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[61], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Field>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/Method;", "private")]
	public JavaArray<Dova.JDK.java.lang.reflect.Method> privateGetPublicMethods()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Method>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/reflect/Method;)[Ljava/lang/reflect/Method;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.reflect.Method> copyMethods(JavaArray<Dova.JDK.java.lang.reflect.Method> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[63], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Method>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/reflect/Constructor;)[Ljava/lang/reflect/Constructor;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.reflect.Constructor> copyConstructors(JavaArray<Dova.JDK.java.lang.reflect.Constructor> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[64], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Constructor>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/reflect/Field;", "private")]
	public Dova.JDK.java.lang.reflect.Field getField0(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Field>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", "private")]
	public Dova.JDK.java.lang.reflect.Method getMethod0(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Class> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String methodToString(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Class> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/Class;", "private native")]
	public JavaArray<Dova.JDK.java.lang.Class> getDeclaredClasses0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("(Z)[Ljava/lang/reflect/Field;", "private")]
	public JavaArray<Dova.JDK.java.lang.reflect.Field> privateGetDeclaredFields(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Field>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/RecordComponent;", "private native")]
	public JavaArray<Dova.JDK.java.lang.reflect.RecordComponent> getRecordComponents0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.RecordComponent>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/reflect/Field;Ljava/lang/String;)Ljava/lang/reflect/Field;", "private static")]
	public static Dova.JDK.java.lang.reflect.Field searchFields(JavaArray<Dova.JDK.java.lang.reflect.Field> arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[71], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Field>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/reflect/Method;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method searchMethods(JavaArray<Dova.JDK.java.lang.reflect.Method> arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Class> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[72], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String resolveName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;)Z", "private")]
	public bool isOpenToCaller(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[74], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/InputStream;", "public")]
	public Dova.JDK.java.io.InputStream getResourceAsStream(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/net/URL;", "public")]
	public Dova.JDK.java.net.URL getResource(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/ProtectionDomain;", "")]
	public Dova.JDK.java.security.ProtectionDomain protectionDomain()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.ProtectionDomain>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/ProtectionDomain;", "private native")]
	public Dova.JDK.java.security.ProtectionDomain getProtectionDomain0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.ProtectionDomain>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getPackageName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[79]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/ref/SoftReference;I)Ljava/lang/Class$ReflectionData;", "private")]
	public Dova.JDK.java.lang.Class.ReflectionData newReflectionData(Dova.JDK.java.lang.@ref.SoftReference arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[80], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class.ReflectionData>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private native")]
	public Dova.JDK.java.lang.String getGenericSignature0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[81]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Executable;)[B", "static")]
	public static JavaArray<byte> getExecutableTypeAnnotationBytes(Dova.JDK.java.lang.reflect.Executable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[82], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Z)[Ljava/lang/reflect/Field;", "private native")]
	public JavaArray<Dova.JDK.java.lang.reflect.Field> getDeclaredFields0(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[83], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Field>>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;[Ljava/lang/reflect/Field;)V", "private static")]
	public static void addAll(Dova.JDK.java.util.Collection arg0, JavaArray<Dova.JDK.java.lang.reflect.Field> arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[84], arg0, arg1);
	}

	[JniSignatureAttribute("(Z)[Ljava/lang/reflect/Constructor;", "private native")]
	public JavaArray<Dova.JDK.java.lang.reflect.Constructor> getDeclaredConstructors0(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[85], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Constructor>>(ret);
	}

	[JniSignatureAttribute("(Z)[Ljava/lang/reflect/Method;", "private native")]
	public JavaArray<Dova.JDK.java.lang.reflect.Method> getDeclaredMethods0(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[86], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Method>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Class;Z)Ljava/lang/PublicMethods$MethodList;", "private")]
	public Dova.JDK.java.lang.PublicMethods.MethodList getMethodsRecursive(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Class> arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[87], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.PublicMethods.MethodList>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "private static native")]
	public static bool desiredAssertionStatus0(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[88], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool desiredAssertionStatus()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[89]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "private native")]
	public bool isRecord0()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[90]);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/lang/Object;", "")]
	public JavaArray<Dova.JDK.java.lang.Object> getEnumConstantsShared()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[91]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", "public transient")]
	public Dova.JDK.java.lang.reflect.Method getMethod(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Class> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[92], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map enumConstantDirectory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[93]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String cannotCastMsg(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[94], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Class$AnnotationData;", "private")]
	public Dova.JDK.java.lang.Class.AnnotationData annotationData()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[95]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class.AnnotationData>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public")]
	public bool isAnnotationPresent(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[96], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/lang/Class$AnnotationData;", "private")]
	public Dova.JDK.java.lang.Class.AnnotationData createAnnotationData(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[97], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class.AnnotationData>(ret);
	}

	[JniSignatureAttribute("()[B", "native")]
	public JavaArray<byte> getRawAnnotations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[98]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/reflect/ConstantPool;", "native")]
	public Dova.JDK.jdk.@internal.reflect.ConstantPool getConstantPool()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[99]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstantPool>(ret);
	}

	[JniSignatureAttribute("(Lsun/reflect/annotation/AnnotationType;Lsun/reflect/annotation/AnnotationType;)Z", "")]
	public bool casAnnotationType(Dova.JDK.sun.reflect.annotation.AnnotationType arg0, Dova.JDK.sun.reflect.annotation.AnnotationType arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[100], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()[B", "native")]
	public JavaArray<byte> getRawTypeAnnotations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[101]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "private native")]
	public Dova.JDK.java.lang.Class getNestHost0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[102]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class getNestHost()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[103]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/Class;", "private native")]
	public JavaArray<Dova.JDK.java.lang.Class> getNestMembers0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[104]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String descriptorString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[105]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/Class;", "private native")]
	public JavaArray<Dova.JDK.java.lang.Class> getPermittedSubclasses0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[106]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/SecurityManager;Ljava/lang/ClassLoader;[Ljava/lang/Class;)V", "private static")]
	public static void checkPackageAccessForPermittedSubclasses(Dova.JDK.java.lang.SecurityManager arg0, Dova.JDK.java.lang.ClassLoader arg1, JavaArray<Dova.JDK.java.lang.Class> arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[107], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()[Ljava/lang/Class;", "public")]
	public JavaArray<Dova.JDK.java.lang.Class> getPermittedSubclasses()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[108]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/TypeDescriptor$OfField;", "public volatile")]
	public Dova.JDK.java.lang.invoke.TypeDescriptor.OfField arrayType_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[109]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.TypeDescriptor.OfField>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class arrayType_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[110]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "private")]
	public bool isDirectSubType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[111], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "private static native")]
	public static void registerNatives()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[112]);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toGenericString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[113]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/TypeVariable;)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String typeVarBounds(Dova.JDK.java.lang.reflect.TypeVariable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[114], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isSynthetic()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[115]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object getClassData()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[116]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Type;", "public")]
	public Dova.JDK.java.lang.reflect.Type getGenericSuperclass()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[117]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Package;", "public")]
	public Dova.JDK.java.lang.Package getPackage()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[118]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/Type;", "public")]
	public JavaArray<Dova.JDK.java.lang.reflect.Type> getGenericInterfaces()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[119]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Type>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/Object;", "public native")]
	public JavaArray<Dova.JDK.java.lang.Object> getSigners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[120]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)V", "native")]
	public void setSigners(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[121], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Method;", "public")]
	public Dova.JDK.java.lang.reflect.Method getEnclosingMethod()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[122]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Constructor;", "public")]
	public Dova.JDK.java.lang.reflect.Constructor getEnclosingConstructor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[123]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class getDeclaringClass()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[124]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getTypeName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[125]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isAnonymousClass()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[126]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isLocalClass()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[127]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isMemberClass()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[128]);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/lang/Class;", "public")]
	public JavaArray<Dova.JDK.java.lang.Class> getClasses()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[129]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/Field;", "public")]
	public JavaArray<Dova.JDK.java.lang.reflect.Field> getFields()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[130]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Field>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/Method;", "public")]
	public JavaArray<Dova.JDK.java.lang.reflect.Method> getMethods()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[131]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Method>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/Constructor;", "public")]
	public JavaArray<Dova.JDK.java.lang.reflect.Constructor> getConstructors()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[132]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Constructor>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/reflect/Field;", "public")]
	public Dova.JDK.java.lang.reflect.Field getField(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[133], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Field>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", "public transient")]
	public Dova.JDK.java.lang.reflect.Constructor getConstructor(JavaArray<Dova.JDK.java.lang.Class> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[134], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/Class;", "public")]
	public JavaArray<Dova.JDK.java.lang.Class> getDeclaredClasses()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[135]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/Field;", "public")]
	public JavaArray<Dova.JDK.java.lang.reflect.Field> getDeclaredFields()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[136]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Field>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/RecordComponent;", "public")]
	public JavaArray<Dova.JDK.java.lang.reflect.RecordComponent> getRecordComponents()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[137]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.RecordComponent>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/Method;", "public")]
	public JavaArray<Dova.JDK.java.lang.reflect.Method> getDeclaredMethods()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[138]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Method>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/Constructor;", "public")]
	public JavaArray<Dova.JDK.java.lang.reflect.Constructor> getDeclaredConstructors()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[139]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Constructor>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/reflect/Field;", "public")]
	public Dova.JDK.java.lang.reflect.Field getDeclaredField(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[140], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Field>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", "public transient")]
	public Dova.JDK.java.lang.reflect.Method getDeclaredMethod(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Class> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[141], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Class;)Ljava/util/List;", "transient")]
	public Dova.JDK.java.util.List getDeclaredPublicMethods(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Class> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[142], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", "public transient")]
	public Dova.JDK.java.lang.reflect.Constructor getDeclaredConstructor(JavaArray<Dova.JDK.java.lang.Class> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[143], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Class;", "static native")]
	public static Dova.JDK.java.lang.Class getPrimitiveClass(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[144], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/Object;", "public")]
	public JavaArray<Dova.JDK.java.lang.Object> getEnumConstants()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[145]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class asSubclass(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[146], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", "public")]
	public Dova.JDK.java.lang.Object getAnnotation(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[147], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", "public")]
	public JavaArray<Dova.JDK.java.lang.Object> getAnnotationsByType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[148], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/annotation/Annotation;", "public")]
	public JavaArray<Dova.JDK.java.lang.annotation.Annotation> getAnnotations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[149]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.annotation.Annotation>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", "public")]
	public Dova.JDK.java.lang.Object getDeclaredAnnotation(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[150], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", "public")]
	public JavaArray<Dova.JDK.java.lang.Object> getDeclaredAnnotationsByType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[151], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/annotation/Annotation;", "public")]
	public JavaArray<Dova.JDK.java.lang.annotation.Annotation> getDeclaredAnnotations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[152]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.annotation.Annotation>>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/annotation/AnnotationType;", "")]
	public Dova.JDK.sun.reflect.annotation.AnnotationType getAnnotationType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[153]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.AnnotationType>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map getDeclaredAnnotationMap()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[154]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedType;", "public")]
	public Dova.JDK.java.lang.reflect.AnnotatedType getAnnotatedSuperclass()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[155]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedType>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/AnnotatedType;", "public")]
	public JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType> getAnnotatedInterfaces()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[156]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedType>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public")]
	public bool isNestmateOf(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[157], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/lang/Class;", "public")]
	public JavaArray<Dova.JDK.java.lang.Class> getNestMembers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[158]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isSealed()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[159]);
		return ret;
	}

	[JniSignatureAttribute("Ljava/lang/Class$ReflectionData;", "private static")]
	public partial class ReflectionData
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ReflectionData()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/Class$ReflectionData;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaredFields", "[Ljava/lang/reflect/Field;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "publicFields", "[Ljava/lang/reflect/Field;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaredMethods", "[Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "publicMethods", "[Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaredConstructors", "[Ljava/lang/reflect/Constructor;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "publicConstructors", "[Ljava/lang/reflect/Constructor;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaredPublicFields", "[Ljava/lang/reflect/Field;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaredPublicMethods", "[Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interfaces", "[Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "simpleName", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canonicalName", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NULL_SENTINEL", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "redefinedCount", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		}

		[JniSignatureAttribute("[Ljava/lang/reflect/Field;", "volatile")]
		public JavaArray<Dova.JDK.java.lang.reflect.Field> declaredFields_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Field>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/reflect/Field;", "volatile")]
		public JavaArray<Dova.JDK.java.lang.reflect.Field> publicFields_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Field>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/reflect/Method;", "volatile")]
		public JavaArray<Dova.JDK.java.lang.reflect.Method> declaredMethods_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Method>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/reflect/Method;", "volatile")]
		public JavaArray<Dova.JDK.java.lang.reflect.Method> publicMethods_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Method>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/reflect/Constructor;", "volatile")]
		public JavaArray<Dova.JDK.java.lang.reflect.Constructor> declaredConstructors_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Constructor>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/reflect/Constructor;", "volatile")]
		public JavaArray<Dova.JDK.java.lang.reflect.Constructor> publicConstructors_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Constructor>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/reflect/Field;", "volatile")]
		public JavaArray<Dova.JDK.java.lang.reflect.Field> declaredPublicFields_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Field>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/reflect/Method;", "volatile")]
		public JavaArray<Dova.JDK.java.lang.reflect.Method> declaredPublicMethods_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Method>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Class;", "volatile")]
		public JavaArray<Dova.JDK.java.lang.Class> interfaces_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String simpleName_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String canonicalName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "static final")]
		public static Dova.JDK.java.lang.String NULL_SENTINEL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "final")]
		public int redefinedCount_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[12]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[12], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ReflectionData(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "")]
		public ReflectionData(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/Class$ReflectionData;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljava/lang/Class$EnclosingMethodInfo;", "private static final")]
	public partial class EnclosingMethodInfo
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EnclosingMethodInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/Class$EnclosingMethodInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enclosingClass", "Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptor", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isMethod", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescriptor", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingClass", "()Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isConstructor", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "validate", "([Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPartial", "()Z"));
		}

		[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
		public Dova.JDK.java.lang.Class enclosingClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String name_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String descriptor_Property
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

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EnclosingMethodInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)V", "")]
		public EnclosingMethodInfo(JavaArray<Dova.JDK.java.lang.Object> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/Class$EnclosingMethodInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isMethod()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String getDescriptor()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Class;", "")]
		public Dova.JDK.java.lang.Class getEnclosingClass()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isConstructor()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)V", "static")]
		public static void validate(JavaArray<Dova.JDK.java.lang.Object> arg0)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isPartial()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/lang/Class$Atomic;", "private static")]
	public partial class Atomic
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Atomic()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/Class$Atomic;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "unsafe", "Ljdk/internal/misc/Unsafe;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "reflectionDataOffset", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "annotationTypeOffset", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "annotationDataOffset", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "casReflectionData", "(Ljava/lang/Class;Ljava/lang/ref/SoftReference;Ljava/lang/ref/SoftReference;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "casAnnotationData", "(Ljava/lang/Class;Ljava/lang/Class$AnnotationData;Ljava/lang/Class$AnnotationData;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "casAnnotationType", "(Ljava/lang/Class;Lsun/reflect/annotation/AnnotationType;Lsun/reflect/annotation/AnnotationType;)Z"));
		}

		[JniSignatureAttribute("Ljdk/internal/misc/Unsafe;", "private static final")]
		public static Dova.JDK.jdk.@internal.misc.Unsafe @unsafe_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.Unsafe>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long reflectionDataOffset_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long annotationTypeOffset_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long annotationDataOffset_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Atomic(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Atomic() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/Class$Atomic;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/ref/SoftReference;Ljava/lang/ref/SoftReference;)Z", "static")]
		public static bool casReflectionData(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.@ref.SoftReference arg1, Dova.JDK.java.lang.@ref.SoftReference arg2)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class$AnnotationData;Ljava/lang/Class$AnnotationData;)Z", "static")]
		public static bool casAnnotationData(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class.AnnotationData arg1, Dova.JDK.java.lang.Class.AnnotationData arg2)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Lsun/reflect/annotation/AnnotationType;Lsun/reflect/annotation/AnnotationType;)Z", "static")]
		public static bool casAnnotationType(Dova.JDK.java.lang.Class arg0, Dova.JDK.sun.reflect.annotation.AnnotationType arg1, Dova.JDK.sun.reflect.annotation.AnnotationType arg2)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/lang/Class$AnnotationData;", "private static")]
	public partial class AnnotationData
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AnnotationData()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/Class$AnnotationData;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotations", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaredAnnotations", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "redefinedCount", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Map;Ljava/util/Map;I)V"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "final")]
		public Dova.JDK.java.util.Map annotations_Property
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

		[JniSignatureAttribute("Ljava/util/Map;", "final")]
		public Dova.JDK.java.util.Map declaredAnnotations_Property
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

		[JniSignatureAttribute("I", "final")]
		public int redefinedCount_Property
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
		public AnnotationData(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/Map;Ljava/util/Map;I)V", "")]
		public AnnotationData(Dova.JDK.java.util.Map arg0, Dova.JDK.java.util.Map arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/Class$AnnotationData;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
