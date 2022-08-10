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

namespace Dova.JDK.sun.reflect.generics.parser;

[JniSignatureAttribute("Lsun/reflect/generics/parser/SignatureParser;", "public")]
public partial class SignatureParser
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SignatureParser()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/generics/parser/SignatureParser;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "input", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "index", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "mark", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EOI", "C"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DEBUG", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SignatureParser", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "make", "()Lsun/reflect/generics/parser/SignatureParser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "init", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "current", "()C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mark", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "error", "(Ljava/lang/String;)Ljava/lang/Error;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "advance", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "remainder", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseTypeSig", "(Ljava/lang/String;)Lsun/reflect/generics/tree/TypeSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseClassSig", "(Ljava/lang/String;)Lsun/reflect/generics/tree/ClassSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseClassSignature", "()Lsun/reflect/generics/tree/ClassSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseMethodTypeSignature", "()Lsun/reflect/generics/tree/MethodTypeSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseTypeSignature", "()Lsun/reflect/generics/tree/TypeSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseZeroOrMoreFormalTypeParameters", "()[Lsun/reflect/generics/tree/FormalTypeParameter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseClassTypeSignature", "()Lsun/reflect/generics/tree/ClassTypeSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseSuperInterfaces", "()[Lsun/reflect/generics/tree/ClassTypeSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseFormalTypeParameters", "()[Lsun/reflect/generics/tree/FormalTypeParameter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseFormalTypeParameter", "()Lsun/reflect/generics/tree/FormalTypeParameter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "progress", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseIdentifier", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseBounds", "()[Lsun/reflect/generics/tree/FieldTypeSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "skipIdentifier", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "markToCurrent", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseFieldTypeSignature", "(Z)Lsun/reflect/generics/tree/FieldTypeSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseFieldTypeSignature", "()Lsun/reflect/generics/tree/FieldTypeSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseTypeVariableSignature", "()Lsun/reflect/generics/tree/TypeVariableSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseArrayTypeSignature", "()Lsun/reflect/generics/tree/ArrayTypeSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parsePackageNameAndSimpleClassTypeSignature", "()Lsun/reflect/generics/tree/SimpleClassTypeSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseClassTypeSignatureSuffix", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseTypeArguments", "()[Lsun/reflect/generics/tree/TypeArgument;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseSimpleClassTypeSignature", "(Z)Lsun/reflect/generics/tree/SimpleClassTypeSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseTypeArgument", "()Lsun/reflect/generics/tree/TypeArgument;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseBaseType", "()Lsun/reflect/generics/tree/BaseType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseFormalParameters", "()[Lsun/reflect/generics/tree/TypeSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseReturnType", "()Lsun/reflect/generics/tree/ReturnType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseZeroOrMoreThrowsSignatures", "()[Lsun/reflect/generics/tree/FieldTypeSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseZeroOrMoreTypeSignatures", "()[Lsun/reflect/generics/tree/TypeSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseThrowsSignature", "()Lsun/reflect/generics/tree/FieldTypeSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseMethodSig", "(Ljava/lang/String;)Lsun/reflect/generics/tree/MethodTypeSignature;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String input_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int index_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("I", "private")]
	public int mark_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("C", "private static final")]
	public static char EOI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SignatureParser(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public SignatureParser() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/reflect/generics/parser/SignatureParser;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/reflect/generics/parser/SignatureParser;", "public static")]
	public static Dova.JDK.sun.reflect.generics.parser.SignatureParser make()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.parser.SignatureParser>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
	public void init(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()C", "private")]
	public char current()
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void mark()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Error;", "private")]
	public Dova.JDK.java.lang.Error error(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Error>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void advance()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String remainder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/reflect/generics/tree/TypeSignature;", "public")]
	public Dova.JDK.sun.reflect.generics.tree.TypeSignature parseTypeSig(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.TypeSignature>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/reflect/generics/tree/ClassSignature;", "public")]
	public Dova.JDK.sun.reflect.generics.tree.ClassSignature parseClassSig(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.ClassSignature>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/ClassSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.ClassSignature parseClassSignature()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.ClassSignature>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/MethodTypeSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.MethodTypeSignature parseMethodTypeSignature()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.MethodTypeSignature>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/TypeSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.TypeSignature parseTypeSignature()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.TypeSignature>(ret);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/FormalTypeParameter;", "private")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter> parseZeroOrMoreFormalTypeParameters()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter>>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/ClassTypeSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature parseClassTypeSignature()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature>(ret);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/ClassTypeSignature;", "private")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature> parseSuperInterfaces()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature>>(ret);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/FormalTypeParameter;", "private")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter> parseFormalTypeParameters()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter>>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/FormalTypeParameter;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter parseFormalTypeParameter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter>(ret);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void progress(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String parseIdentifier()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/FieldTypeSignature;", "private")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> parseBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void skipIdentifier()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20]);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String markToCurrent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Z)Lsun/reflect/generics/tree/FieldTypeSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature parseFieldTypeSignature(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/FieldTypeSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature parseFieldTypeSignature()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/TypeVariableSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.TypeVariableSignature parseTypeVariableSignature()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.TypeVariableSignature>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/ArrayTypeSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.ArrayTypeSignature parseArrayTypeSignature()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.ArrayTypeSignature>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/SimpleClassTypeSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.SimpleClassTypeSignature parsePackageNameAndSimpleClassTypeSignature()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.SimpleClassTypeSignature>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "private")]
	public void parseClassTypeSignatureSuffix(Dova.JDK.java.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/TypeArgument;", "private")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.TypeArgument> parseTypeArguments()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.TypeArgument>>(ret);
	}

	[JniSignatureAttribute("(Z)Lsun/reflect/generics/tree/SimpleClassTypeSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.SimpleClassTypeSignature parseSimpleClassTypeSignature(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.SimpleClassTypeSignature>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/TypeArgument;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.TypeArgument parseTypeArgument()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.TypeArgument>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/BaseType;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.BaseType parseBaseType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.BaseType>(ret);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/TypeSignature;", "private")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.TypeSignature> parseFormalParameters()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.TypeSignature>>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/ReturnType;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.ReturnType parseReturnType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.ReturnType>(ret);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/FieldTypeSignature;", "private")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> parseZeroOrMoreThrowsSignatures()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>>(ret);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/TypeSignature;", "private")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.TypeSignature> parseZeroOrMoreTypeSignatures()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.TypeSignature>>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/FieldTypeSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature parseThrowsSignature()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/reflect/generics/tree/MethodTypeSignature;", "public")]
	public Dova.JDK.sun.reflect.generics.tree.MethodTypeSignature parseMethodSig(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.MethodTypeSignature>(ret);
	}
}
