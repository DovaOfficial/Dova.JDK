/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.javax.swing;

[JniSignatureAttribute("Ljavax/swing/SizeRequirements;", "public")]
public partial class SizeRequirements
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SizeRequirements()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/SizeRequirements;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "minimum", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "preferred", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "maximum", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "alignment", "F"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SizeRequirements", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SizeRequirements", "(IIIF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "calculateTiledPositions", "(ILjavax/swing/SizeRequirements;[Ljavax/swing/SizeRequirements;[I[IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "calculateTiledPositions", "(ILjavax/swing/SizeRequirements;[Ljavax/swing/SizeRequirements;[I[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "calculateAlignedPositions", "(ILjavax/swing/SizeRequirements;[Ljavax/swing/SizeRequirements;[I[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "calculateAlignedPositions", "(ILjavax/swing/SizeRequirements;[Ljavax/swing/SizeRequirements;[I[IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getTiledSizeRequirements", "([Ljavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAlignedSizeRequirements", "([Ljavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "expandedTile", "(IJJJ[Ljavax/swing/SizeRequirements;[I[IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "compressedTile", "(IJJJ[Ljavax/swing/SizeRequirements;[I[IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "adjustSizes", "(I[Ljavax/swing/SizeRequirements;)[I"));
	}

	[JniSignatureAttribute("I", "public")]
	public int minimum_Property
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

	[JniSignatureAttribute("I", "public")]
	public int preferred_Property
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

	[JniSignatureAttribute("I", "public")]
	public int maximum_Property
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

	[JniSignatureAttribute("F", "public")]
	public float alignment_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SizeRequirements(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SizeRequirements() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(IIIF)V", "public")]
	public SizeRequirements(int arg0, int arg1, int arg2, float arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/SizeRequirements;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(ILjavax/swing/SizeRequirements;[Ljavax/swing/SizeRequirements;[I[IZ)V", "public static")]
	public static void calculateTiledPositions(int arg0, Dova.JDK.javax.swing.SizeRequirements arg1, JavaArray<Dova.JDK.javax.swing.SizeRequirements> arg2, JavaArray<int> arg3, JavaArray<int> arg4, bool arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(ILjavax/swing/SizeRequirements;[Ljavax/swing/SizeRequirements;[I[I)V", "public static")]
	public static void calculateTiledPositions(int arg0, Dova.JDK.javax.swing.SizeRequirements arg1, JavaArray<Dova.JDK.javax.swing.SizeRequirements> arg2, JavaArray<int> arg3, JavaArray<int> arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(ILjavax/swing/SizeRequirements;[Ljavax/swing/SizeRequirements;[I[I)V", "public static")]
	public static void calculateAlignedPositions(int arg0, Dova.JDK.javax.swing.SizeRequirements arg1, JavaArray<Dova.JDK.javax.swing.SizeRequirements> arg2, JavaArray<int> arg3, JavaArray<int> arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(ILjavax/swing/SizeRequirements;[Ljavax/swing/SizeRequirements;[I[IZ)V", "public static")]
	public static void calculateAlignedPositions(int arg0, Dova.JDK.javax.swing.SizeRequirements arg1, JavaArray<Dova.JDK.javax.swing.SizeRequirements> arg2, JavaArray<int> arg3, JavaArray<int> arg4, bool arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("([Ljavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;", "public static")]
	public static Dova.JDK.javax.swing.SizeRequirements getTiledSizeRequirements(JavaArray<Dova.JDK.javax.swing.SizeRequirements> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeRequirements>(ret);
	}

	[JniSignatureAttribute("([Ljavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;", "public static")]
	public static Dova.JDK.javax.swing.SizeRequirements getAlignedSizeRequirements(JavaArray<Dova.JDK.javax.swing.SizeRequirements> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeRequirements>(ret);
	}

	[JniSignatureAttribute("(IJJJ[Ljavax/swing/SizeRequirements;[I[IZ)V", "private static")]
	public static void expandedTile(int arg0, long arg1, long arg2, long arg3, JavaArray<Dova.JDK.javax.swing.SizeRequirements> arg4, JavaArray<int> arg5, JavaArray<int> arg6, bool arg7)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(IJJJ[Ljavax/swing/SizeRequirements;[I[IZ)V", "private static")]
	public static void compressedTile(int arg0, long arg1, long arg2, long arg3, JavaArray<Dova.JDK.javax.swing.SizeRequirements> arg4, JavaArray<int> arg5, JavaArray<int> arg6, bool arg7)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(I[Ljavax/swing/SizeRequirements;)[I", "public static")]
	public static JavaArray<int> adjustSizes(int arg0, JavaArray<Dova.JDK.javax.swing.SizeRequirements> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}
}
