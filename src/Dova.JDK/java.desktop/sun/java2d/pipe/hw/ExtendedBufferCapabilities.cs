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

namespace Dova.JDK.sun.java2d.pipe.hw;

[JniSignatureAttribute("Lsun/java2d/pipe/hw/ExtendedBufferCapabilities;", "public")]
public partial class ExtendedBufferCapabilities
	: Dova.JDK.java.awt.BufferCapabilities
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ExtendedBufferCapabilities()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/pipe/hw/ExtendedBufferCapabilities;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "vsync", "Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ExtendedBufferCapabilities", "(Ljava/awt/BufferCapabilities;Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ExtendedBufferCapabilities", "(Ljava/awt/ImageCapabilities;Ljava/awt/ImageCapabilities;Ljava/awt/BufferCapabilities$FlipContents;Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ExtendedBufferCapabilities", "(Ljava/awt/ImageCapabilities;Ljava/awt/ImageCapabilities;Ljava/awt/BufferCapabilities$FlipContents;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ExtendedBufferCapabilities", "(Ljava/awt/BufferCapabilities;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "derive", "(Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;)Lsun/java2d/pipe/hw/ExtendedBufferCapabilities;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isPageFlipping", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getVSync", "()Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;"));
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;", "private")]
	public Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities.VSyncType vsync_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities.VSyncType>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ExtendedBufferCapabilities(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/BufferCapabilities;Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;)V", "public")]
	public ExtendedBufferCapabilities(Dova.JDK.java.awt.BufferCapabilities arg0, Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities.VSyncType arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/ImageCapabilities;Ljava/awt/ImageCapabilities;Ljava/awt/BufferCapabilities$FlipContents;Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;)V", "public")]
	public ExtendedBufferCapabilities(Dova.JDK.java.awt.ImageCapabilities arg0, Dova.JDK.java.awt.ImageCapabilities arg1, Dova.JDK.java.awt.BufferCapabilities.FlipContents arg2, Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities.VSyncType arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/ImageCapabilities;Ljava/awt/ImageCapabilities;Ljava/awt/BufferCapabilities$FlipContents;)V", "public")]
	public ExtendedBufferCapabilities(Dova.JDK.java.awt.ImageCapabilities arg0, Dova.JDK.java.awt.ImageCapabilities arg1, Dova.JDK.java.awt.BufferCapabilities.FlipContents arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/BufferCapabilities;)V", "public")]
	public ExtendedBufferCapabilities(Dova.JDK.java.awt.BufferCapabilities arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/pipe/hw/ExtendedBufferCapabilities;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;)Lsun/java2d/pipe/hw/ExtendedBufferCapabilities;", "public")]
	public Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities derive(Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities.VSyncType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities>(ret);
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool isPageFlipping()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;", "public")]
	public Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities.VSyncType getVSync()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities.VSyncType>(ret);
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;", "public static final")]
	public partial class VSyncType
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static VSyncType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "VSYNC_DEFAULT", "Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "VSYNC_ON", "Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "VSYNC_OFF", "Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "id", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "VSyncType", "(Ljava/lang/String;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "id", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;"));
		}

		[JniSignatureAttribute("Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;", "public static final")]
		public static Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities.VSyncType VSYNC_DEFAULT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities.VSyncType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;", "public static final")]
		public static Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities.VSyncType VSYNC_ON_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities.VSyncType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;", "public static final")]
		public static Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities.VSyncType VSYNC_OFF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities.VSyncType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "private")]
		public int id_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("[Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;", "private static final")]
		public static JavaArray<Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities.VSyncType> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities.VSyncType>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public VSyncType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;II)V", "private")]
		public VSyncType(Dova.JDK.java.lang.String arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;", "public static")]
		public static JavaArray<Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities.VSyncType> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities.VSyncType>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;", "public static")]
		public static Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities.VSyncType valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities.VSyncType>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int id()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()[Lsun/java2d/pipe/hw/ExtendedBufferCapabilities$VSyncType;", "private static")]
		public static JavaArray<Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities.VSyncType> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.java2d.pipe.hw.ExtendedBufferCapabilities.VSyncType>>(ret);
		}
	}
}
