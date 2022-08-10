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

namespace Dova.JDK.com.sun.tools.javac.code;

[JniSignatureAttribute("Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public")]
public partial class TypeAnnotationPosition
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TypeAnnotationPosition()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/TypeAnnotationPosition;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "emptyPath", "Lcom/sun/tools/javac/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "type", "Lcom/sun/tools/javac/code/TargetType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "location", "Lcom/sun/tools/javac/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "pos", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "isValidOffset", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "offset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lvarOffset", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lvarLength", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lvarIndex", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "bound_index", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "parameter_index", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "type_index", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "exception_index", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "exceptionStartPos", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "onLambda", "Lcom/sun/tools/javac/tree/JCTree$JCLambda;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "unknown", "Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TypeAnnotationPosition", "(Lcom/sun/tools/javac/code/TargetType;IILcom/sun/tools/javac/tree/JCTree$JCLambda;IILcom/sun/tools/javac/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "field", "(I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "field", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "field", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hasExceptionIndex", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hasCatchType", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCatchType", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getStartPos", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getBinaryFromTypePath", "(Ljava/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "emitToClassfile", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getTypePathFromBinary", "(Ljava/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "newObj", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "newObj", "(I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "newObj", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodReturn", "(I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodReturn", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodReturn", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodRef", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodRef", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "instanceOf", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "instanceOf", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "constructorRef", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "constructorRef", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "localVariable", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "localVariable", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "localVariable", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "resourceVariable", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "resourceVariable", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "resourceVariable", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "exceptionParameter", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "exceptionParameter", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "exceptionParameter", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setExceptionIndex", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodReceiver", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodReceiver", "(I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodReceiver", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodTypeParameter", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodTypeParameter", "(Lcom/sun/tools/javac/util/List;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "typeParameterBound", "(Lcom/sun/tools/javac/util/List;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "typeParameterBound", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;III)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodTypeParameterBound", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;III)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodTypeParameterBound", "(Lcom/sun/tools/javac/util/List;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "classExtends", "(I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "classExtends", "(II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "classExtends", "(Lcom/sun/tools/javac/util/List;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "classExtends", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "classExtends", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodThrows", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodThrows", "(Lcom/sun/tools/javac/util/List;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodParameter", "(II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodParameter", "(Lcom/sun/tools/javac/util/List;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodParameter", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodParameter", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "typeCast", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "typeCast", "(Lcom/sun/tools/javac/util/List;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "constructorInvocationTypeArg", "(Lcom/sun/tools/javac/util/List;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "constructorInvocationTypeArg", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodInvocationTypeArg", "(Lcom/sun/tools/javac/util/List;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodInvocationTypeArg", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "constructorRefTypeArg", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "constructorRefTypeArg", "(Lcom/sun/tools/javac/util/List;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodRefTypeArg", "(Lcom/sun/tools/javac/util/List;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "methodRefTypeArg", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getExceptionIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setCatchInfo", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "matchesPos", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "updatePosOffset", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "typeParameter", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "typeParameter", "(Lcom/sun/tools/javac/util/List;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.util.List emptyPath_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/TargetType;", "public final")]
	public Dova.JDK.com.sun.tools.javac.code.TargetType type_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TargetType>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List location_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "public final")]
	public int pos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("Z", "public")]
	public bool isValidOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("I", "public")]
	public int offset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("[I", "public")]
	public JavaArray<int> lvarOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[I", "public")]
	public JavaArray<int> lvarLength_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[I", "public")]
	public JavaArray<int> lvarIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "public final")]
	public int bound_index_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
	}

	[JniSignatureAttribute("I", "public")]
	public int parameter_index_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
	}

	[JniSignatureAttribute("I", "public final")]
	public int type_index_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[11], value);
	}

	[JniSignatureAttribute("I", "private")]
	public int exception_index_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[12], value);
	}

	[JniSignatureAttribute("I", "private")]
	public int exceptionStartPos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[13], value);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCLambda;", "public final")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda onLambda_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition unknown_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TypeAnnotationPosition(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TargetType;IILcom/sun/tools/javac/tree/JCTree$JCLambda;IILcom/sun/tools/javac/util/List;)V", "private")]
	public TypeAnnotationPosition(Dova.JDK.com.sun.tools.javac.code.TargetType arg0, int arg1, int arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg3, int arg4, int arg5, Dova.JDK.com.sun.tools.javac.util.List arg6) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/TypeAnnotationPosition;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition field(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition field(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition field(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasExceptionIndex()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasCatchType()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getCatchType()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getStartPos()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/tools/javac/util/List;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.util.List getBinaryFromTypePath(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool emitToClassfile()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/tools/javac/util/List;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.util.List getTypePathFromBinary(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition newObj(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition newObj(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition newObj(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodReturn(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodReturn(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodReturn(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodRef(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodRef(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition instanceOf(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition instanceOf(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition constructorRef(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition constructorRef(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition localVariable(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition localVariable(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition localVariable(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition resourceVariable(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition resourceVariable(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition resourceVariable(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition exceptionParameter(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition exceptionParameter(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition exceptionParameter(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setExceptionIndex(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodReceiver(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodReceiver(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodReceiver(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodTypeParameter(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodTypeParameter(Dova.JDK.com.sun.tools.javac.util.List arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition typeParameterBound(Dova.JDK.com.sun.tools.javac.util.List arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;III)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition typeParameterBound(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;III)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodTypeParameterBound(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodTypeParameterBound(Dova.JDK.com.sun.tools.javac.util.List arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[41], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition classExtends(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition classExtends(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[43], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition classExtends(Dova.JDK.com.sun.tools.javac.util.List arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[44], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition classExtends(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[45], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition classExtends(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[46], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodThrows(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[47], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodThrows(Dova.JDK.com.sun.tools.javac.util.List arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[48], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodParameter(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[49], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodParameter(Dova.JDK.com.sun.tools.javac.util.List arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[50], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodParameter(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[51], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodParameter(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[52], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition typeCast(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[53], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition typeCast(Dova.JDK.com.sun.tools.javac.util.List arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[54], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition constructorInvocationTypeArg(Dova.JDK.com.sun.tools.javac.util.List arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[55], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition constructorInvocationTypeArg(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[56], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodInvocationTypeArg(Dova.JDK.com.sun.tools.javac.util.List arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[57], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodInvocationTypeArg(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[58], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition constructorRefTypeArg(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[59], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition constructorRefTypeArg(Dova.JDK.com.sun.tools.javac.util.List arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[60], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodRefTypeArg(Dova.JDK.com.sun.tools.javac.util.List arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[61], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition methodRefTypeArg(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[62], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getExceptionIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[63]);
		return ret;
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void setCatchInfo(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool matchesPos(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void updatePosOffset(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCLambda;II)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition typeParameter(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[67], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;I)Lcom/sun/tools/javac/code/TypeAnnotationPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition typeParameter(Dova.JDK.com.sun.tools.javac.util.List arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[68], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntry;", "public static")]
	public partial class TypePathEntry
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypePathEntry()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntry;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "bytesPerEntry", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "tag", "Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "arg", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ARRAY", "Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntry;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INNER_TYPE", "Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntry;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "WILDCARD", "Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntry;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TypePathEntry", "(Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TypePathEntry", "(Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "fromBinary", "(II)Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntry;"));
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int bytesPerEntry_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;", "public final")]
		public Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntryKind tag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntryKind>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "public final")]
		public int arg_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntry;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntry ARRAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntry>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntry;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntry INNER_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntry>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntry;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntry WILDCARD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntry>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TypePathEntry(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;)V", "private")]
		public TypePathEntry(Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntryKind arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;I)V", "public")]
		public TypePathEntry(Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntryKind arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntry;";
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

		[JniSignatureAttribute("(II)Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntry;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntry fromBinary(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntry>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;", "public static final")]
	public partial class TypePathEntryKind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypePathEntryKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ARRAY", "Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INNER_TYPE", "Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "WILDCARD", "Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TYPE_ARGUMENT", "Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "tag", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TypePathEntryKind", "(Ljava/lang/String;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntryKind ARRAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntryKind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntryKind INNER_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntryKind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntryKind WILDCARD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntryKind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntryKind TYPE_ARGUMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntryKind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "public final")]
		public int tag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntryKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntryKind>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TypePathEntryKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;II)V", "private")]
		public TypePathEntryKind(Dova.JDK.java.lang.String arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntryKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntryKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntryKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntryKind>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/TypeAnnotationPosition$TypePathEntryKind;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntryKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.TypeAnnotationPosition.TypePathEntryKind>>(ret);
		}
	}
}
