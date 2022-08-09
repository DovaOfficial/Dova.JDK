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

namespace Dova.JDK.javax.imageio.plugins.tiff;

[JniSignatureAttribute("Ljavax/imageio/plugins/tiff/ExifParentTIFFTagSet;", "public final")]
public partial class ExifParentTIFFTagSet
	: Dova.JDK.javax.imageio.plugins.tiff.TIFFTagSet
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ExifParentTIFFTagSet()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/imageio/plugins/tiff/ExifParentTIFFTagSet;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "theInstance", "Ljavax/imageio/plugins/tiff/ExifParentTIFFTagSet;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TAG_EXIF_IFD_POINTER", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TAG_GPS_INFO_IFD_POINTER", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "tags", "Ljava/util/List;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ExifParentTIFFTagSet", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "()Ljavax/imageio/plugins/tiff/ExifParentTIFFTagSet;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "initTags", "()V"));
	}

	[JniSignatureAttribute("Ljavax/imageio/plugins/tiff/ExifParentTIFFTagSet;", "private static")]
	public static Dova.JDK.javax.imageio.plugins.tiff.ExifParentTIFFTagSet theInstance_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.plugins.tiff.ExifParentTIFFTagSet>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int TAG_EXIF_IFD_POINTER_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int TAG_GPS_INFO_IFD_POINTER_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List tags_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ExifParentTIFFTagSet(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public ExifParentTIFFTagSet() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/imageio/plugins/tiff/ExifParentTIFFTagSet;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/imageio/plugins/tiff/ExifParentTIFFTagSet;", "public static synchronized")]
	public static Dova.JDK.javax.imageio.plugins.tiff.ExifParentTIFFTagSet getInstance()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.plugins.tiff.ExifParentTIFFTagSet>(ret);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void initTags()
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("Ljavax/imageio/plugins/tiff/ExifParentTIFFTagSet$ExifIFDPointer;", "static")]
	public partial class ExifIFDPointer
		: Dova.JDK.javax.imageio.plugins.tiff.TIFFTag
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ExifIFDPointer()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/imageio/plugins/tiff/ExifParentTIFFTagSet$ExifIFDPointer;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ExifIFDPointer", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ExifIFDPointer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public ExifIFDPointer() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/imageio/plugins/tiff/ExifParentTIFFTagSet$ExifIFDPointer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljavax/imageio/plugins/tiff/ExifParentTIFFTagSet$GPSInfoIFDPointer;", "static")]
	public partial class GPSInfoIFDPointer
		: Dova.JDK.javax.imageio.plugins.tiff.TIFFTag
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GPSInfoIFDPointer()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/imageio/plugins/tiff/ExifParentTIFFTagSet$GPSInfoIFDPointer;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "GPSInfoIFDPointer", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public GPSInfoIFDPointer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public GPSInfoIFDPointer() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/imageio/plugins/tiff/ExifParentTIFFTagSet$GPSInfoIFDPointer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}