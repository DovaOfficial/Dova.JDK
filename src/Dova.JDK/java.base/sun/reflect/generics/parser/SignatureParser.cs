/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

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
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/reflect/generics/parser/SignatureParser;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "input", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "index", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "mark", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "EOI", "C"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DEBUG", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "SignatureParser", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "make", "()Lsun/reflect/generics/parser/SignatureParser;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "init", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "current", "()C"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "mark", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "error", "(Ljava/lang/String;)Ljava/lang/Error;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "advance", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "remainder", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseTypeSig", "(Ljava/lang/String;)Lsun/reflect/generics/tree/TypeSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseClassSig", "(Ljava/lang/String;)Lsun/reflect/generics/tree/ClassSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseClassSignature", "()Lsun/reflect/generics/tree/ClassSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseMethodTypeSignature", "()Lsun/reflect/generics/tree/MethodTypeSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseTypeSignature", "()Lsun/reflect/generics/tree/TypeSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseZeroOrMoreFormalTypeParameters", "()[Lsun/reflect/generics/tree/FormalTypeParameter;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseClassTypeSignature", "()Lsun/reflect/generics/tree/ClassTypeSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseSuperInterfaces", "()[Lsun/reflect/generics/tree/ClassTypeSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseFormalTypeParameters", "()[Lsun/reflect/generics/tree/FormalTypeParameter;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseFormalTypeParameter", "()Lsun/reflect/generics/tree/FormalTypeParameter;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "progress", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseIdentifier", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseBounds", "()[Lsun/reflect/generics/tree/FieldTypeSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "skipIdentifier", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "markToCurrent", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseFieldTypeSignature", "(Z)Lsun/reflect/generics/tree/FieldTypeSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseFieldTypeSignature", "()Lsun/reflect/generics/tree/FieldTypeSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseTypeVariableSignature", "()Lsun/reflect/generics/tree/TypeVariableSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseArrayTypeSignature", "()Lsun/reflect/generics/tree/ArrayTypeSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parsePackageNameAndSimpleClassTypeSignature", "()Lsun/reflect/generics/tree/SimpleClassTypeSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseClassTypeSignatureSuffix", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseTypeArguments", "()[Lsun/reflect/generics/tree/TypeArgument;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseSimpleClassTypeSignature", "(Z)Lsun/reflect/generics/tree/SimpleClassTypeSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseTypeArgument", "()Lsun/reflect/generics/tree/TypeArgument;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseBaseType", "()Lsun/reflect/generics/tree/BaseType;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseFormalParameters", "()[Lsun/reflect/generics/tree/TypeSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseReturnType", "()Lsun/reflect/generics/tree/ReturnType;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseZeroOrMoreThrowsSignatures", "()[Lsun/reflect/generics/tree/FieldTypeSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseZeroOrMoreTypeSignatures", "()[Lsun/reflect/generics/tree/TypeSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseThrowsSignature", "()Lsun/reflect/generics/tree/FieldTypeSignature;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parseMethodSig", "(Ljava/lang/String;)Lsun/reflect/generics/tree/MethodTypeSignature;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String input_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int index_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("I", "private")]
	public int mark_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("C", "private static final")]
	public static char EOI_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SignatureParser(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public SignatureParser() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/reflect/generics/parser/SignatureParser;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/reflect/generics/parser/SignatureParser;", "public static")]
	public static Dova.JDK.sun.reflect.generics.parser.SignatureParser make()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.parser.SignatureParser>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
	public void init(Dova.JDK.java.lang.String arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()C", "private")]
	public char current()
	{
		var ret = DovaJvm.Vm.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void mark()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Error;", "private")]
	public Dova.JDK.java.lang.Error error(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Error>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void advance()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String remainder()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/reflect/generics/tree/TypeSignature;", "public")]
	public Dova.JDK.sun.reflect.generics.tree.TypeSignature parseTypeSig(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.TypeSignature>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/reflect/generics/tree/ClassSignature;", "public")]
	public Dova.JDK.sun.reflect.generics.tree.ClassSignature parseClassSig(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.ClassSignature>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/ClassSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.ClassSignature parseClassSignature()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.ClassSignature>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/MethodTypeSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.MethodTypeSignature parseMethodTypeSignature()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.MethodTypeSignature>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/TypeSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.TypeSignature parseTypeSignature()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.TypeSignature>(ret);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/FormalTypeParameter;", "private")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter> parseZeroOrMoreFormalTypeParameters()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter>>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/ClassTypeSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature parseClassTypeSignature()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature>(ret);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/ClassTypeSignature;", "private")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature> parseSuperInterfaces()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature>>(ret);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/FormalTypeParameter;", "private")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter> parseFormalTypeParameters()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter>>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/FormalTypeParameter;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter parseFormalTypeParameter()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter>(ret);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void progress(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String parseIdentifier()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/FieldTypeSignature;", "private")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> parseBounds()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void skipIdentifier()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20]);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String markToCurrent()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Z)Lsun/reflect/generics/tree/FieldTypeSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature parseFieldTypeSignature(bool arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/FieldTypeSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature parseFieldTypeSignature()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/TypeVariableSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.TypeVariableSignature parseTypeVariableSignature()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.TypeVariableSignature>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/ArrayTypeSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.ArrayTypeSignature parseArrayTypeSignature()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.ArrayTypeSignature>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/SimpleClassTypeSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.SimpleClassTypeSignature parsePackageNameAndSimpleClassTypeSignature()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.SimpleClassTypeSignature>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "private")]
	public void parseClassTypeSignatureSuffix(Dova.JDK.java.util.List arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/TypeArgument;", "private")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.TypeArgument> parseTypeArguments()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.TypeArgument>>(ret);
	}

	[JniSignatureAttribute("(Z)Lsun/reflect/generics/tree/SimpleClassTypeSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.SimpleClassTypeSignature parseSimpleClassTypeSignature(bool arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.SimpleClassTypeSignature>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/TypeArgument;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.TypeArgument parseTypeArgument()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.TypeArgument>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/BaseType;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.BaseType parseBaseType()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.BaseType>(ret);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/TypeSignature;", "private")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.TypeSignature> parseFormalParameters()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.TypeSignature>>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/ReturnType;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.ReturnType parseReturnType()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.ReturnType>(ret);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/FieldTypeSignature;", "private")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> parseZeroOrMoreThrowsSignatures()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>>(ret);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/TypeSignature;", "private")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.TypeSignature> parseZeroOrMoreTypeSignatures()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.TypeSignature>>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/generics/tree/FieldTypeSignature;", "private")]
	public Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature parseThrowsSignature()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/reflect/generics/tree/MethodTypeSignature;", "public")]
	public Dova.JDK.sun.reflect.generics.tree.MethodTypeSignature parseMethodSig(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.MethodTypeSignature>(ret);
	}
}
