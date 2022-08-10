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

namespace Dova.JDK.sun.reflect.annotation;

[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation;", "public final")]
public partial class TypeAnnotation
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TypeAnnotation()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/annotation/TypeAnnotation;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "targetInfo", "Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTargetInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "loc", "Lsun/reflect/annotation/TypeAnnotation$LocationInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "annotation", "Ljava/lang/annotation/Annotation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "baseDeclaration", "Ljava/lang/reflect/AnnotatedElement;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TypeAnnotation", "(Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTargetInfo;Lsun/reflect/annotation/TypeAnnotation$LocationInfo;Ljava/lang/annotation/Annotation;Ljava/lang/reflect/AnnotatedElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "filter", "([Lsun/reflect/annotation/TypeAnnotation;Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAnnotation", "()Ljava/lang/annotation/Annotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getBaseDeclaration", "()Ljava/lang/reflect/AnnotatedElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLocationInfo", "()Lsun/reflect/annotation/TypeAnnotation$LocationInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTargetInfo", "()Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTargetInfo;"));
	}

	[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTargetInfo;", "private final")]
	public Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTargetInfo targetInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTargetInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation$LocationInfo;", "private final")]
	public Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo loc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/annotation/Annotation;", "private final")]
	public Dova.JDK.java.lang.annotation.Annotation annotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.annotation.Annotation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/AnnotatedElement;", "private final")]
	public Dova.JDK.java.lang.reflect.AnnotatedElement baseDeclaration_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TypeAnnotation(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTargetInfo;Lsun/reflect/annotation/TypeAnnotation$LocationInfo;Ljava/lang/annotation/Annotation;Ljava/lang/reflect/AnnotatedElement;)V", "public")]
	public TypeAnnotation(Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTargetInfo arg0, Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo arg1, Dova.JDK.java.lang.annotation.Annotation arg2, Dova.JDK.java.lang.reflect.AnnotatedElement arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/reflect/annotation/TypeAnnotation;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([Lsun/reflect/annotation/TypeAnnotation;Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;)Ljava/util/List;", "public static")]
	public static Dova.JDK.java.util.List filter(JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> arg0, Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/annotation/Annotation;", "public")]
	public Dova.JDK.java.lang.annotation.Annotation getAnnotation()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.annotation.Annotation>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedElement;", "public")]
	public Dova.JDK.java.lang.reflect.AnnotatedElement getBaseDeclaration()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/annotation/TypeAnnotation$LocationInfo;", "public")]
	public Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo getLocationInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo>(ret);
	}

	[JniSignatureAttribute("()Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTargetInfo;", "public")]
	public Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTargetInfo getTargetInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTargetInfo>(ret);
	}

	[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTargetInfo;", "public static final")]
	public partial class TypeAnnotationTargetInfo
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypeAnnotationTargetInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTargetInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "target", "Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "count", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "secondaryIndex", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "UNUSED_INDEX", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TypeAnnotationTargetInfo", "(Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;II)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TypeAnnotationTargetInfo", "(Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TypeAnnotationTargetInfo", "(Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTarget", "()Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSecondaryIndex", "()I"));
		}

		[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;", "private final")]
		public Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget target_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int count_Property
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

		[JniSignatureAttribute("I", "private final")]
		public int secondaryIndex_Property
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

		[JniSignatureAttribute("I", "private static final")]
		public static int UNUSED_INDEX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TypeAnnotationTargetInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;II)V", "public")]
		public TypeAnnotationTargetInfo(Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;I)V", "public")]
		public TypeAnnotationTargetInfo(Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;)V", "public")]
		public TypeAnnotationTargetInfo(Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTargetInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;", "public")]
		public Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget getTarget()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getSecondaryIndex()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation$LocationInfo;", "public static final")]
	public partial class LocationInfo
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LocationInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/annotation/TypeAnnotation$LocationInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "depth", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "locations", "[Lsun/reflect/annotation/TypeAnnotation$LocationInfo$Location;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BASE_LOCATION", "Lsun/reflect/annotation/TypeAnnotation$LocationInfo;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LocationInfo", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LocationInfo", "(I[Lsun/reflect/annotation/TypeAnnotation$LocationInfo$Location;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "filter", "([Lsun/reflect/annotation/TypeAnnotation;)[Lsun/reflect/annotation/TypeAnnotation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pushInner", "()Lsun/reflect/annotation/TypeAnnotation$LocationInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "popLocation", "(B)Lsun/reflect/annotation/TypeAnnotation$LocationInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isSameLocationInfo", "(Lsun/reflect/annotation/TypeAnnotation$LocationInfo;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pushLocation", "(BS)Lsun/reflect/annotation/TypeAnnotation$LocationInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseLocationInfo", "(Ljava/nio/ByteBuffer;)Lsun/reflect/annotation/TypeAnnotation$LocationInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pushArray", "()Lsun/reflect/annotation/TypeAnnotation$LocationInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pushWildcard", "()Lsun/reflect/annotation/TypeAnnotation$LocationInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pushTypeArg", "(S)Lsun/reflect/annotation/TypeAnnotation$LocationInfo;"));
		}

		[JniSignatureAttribute("I", "private final")]
		public int depth_Property
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

		[JniSignatureAttribute("[Lsun/reflect/annotation/TypeAnnotation$LocationInfo$Location;", "private final")]
		public JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo.Location> locations_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo.Location>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation$LocationInfo;", "public static final")]
		public static Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo BASE_LOCATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LocationInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public LocationInfo() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(I[Lsun/reflect/annotation/TypeAnnotation$LocationInfo$Location;)V", "private")]
		public LocationInfo(int arg0, JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo.Location> arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/reflect/annotation/TypeAnnotation$LocationInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([Lsun/reflect/annotation/TypeAnnotation;)[Lsun/reflect/annotation/TypeAnnotation;", "public")]
		public JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> filter(JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation>>(ret);
		}

		[JniSignatureAttribute("()Lsun/reflect/annotation/TypeAnnotation$LocationInfo;", "public")]
		public Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo pushInner()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo>(ret);
		}

		[JniSignatureAttribute("(B)Lsun/reflect/annotation/TypeAnnotation$LocationInfo;", "public")]
		public Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo popLocation(byte arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo>(ret);
		}

		[JniSignatureAttribute("(Lsun/reflect/annotation/TypeAnnotation$LocationInfo;)Z", "")]
		public bool isSameLocationInfo(Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(BS)Lsun/reflect/annotation/TypeAnnotation$LocationInfo;", "public")]
		public Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo pushLocation(byte arg0, short arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Lsun/reflect/annotation/TypeAnnotation$LocationInfo;", "public static")]
		public static Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo parseLocationInfo(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo>(ret);
		}

		[JniSignatureAttribute("()Lsun/reflect/annotation/TypeAnnotation$LocationInfo;", "public")]
		public Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo pushArray()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo>(ret);
		}

		[JniSignatureAttribute("()Lsun/reflect/annotation/TypeAnnotation$LocationInfo;", "public")]
		public Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo pushWildcard()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo>(ret);
		}

		[JniSignatureAttribute("(S)Lsun/reflect/annotation/TypeAnnotation$LocationInfo;", "public")]
		public Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo pushTypeArg(short arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo>(ret);
		}

		[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation$LocationInfo$Location;", "public static final")]
		public partial class Location
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Location()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/annotation/TypeAnnotation$LocationInfo$Location;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "tag", "B"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "index", "S"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Location", "(BS)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isSameLocation", "(Lsun/reflect/annotation/TypeAnnotation$LocationInfo$Location;)Z"));
			}

			[JniSignatureAttribute("B", "public final")]
			public byte tag_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[0]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[0], value);
				}
			}

			[JniSignatureAttribute("S", "public final")]
			public short index_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Location(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(BS)V", "public")]
			public Location(byte arg0, short arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/reflect/annotation/TypeAnnotation$LocationInfo$Location;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lsun/reflect/annotation/TypeAnnotation$LocationInfo$Location;)Z", "")]
			public bool isSameLocation(Dova.JDK.sun.reflect.annotation.TypeAnnotation.LocationInfo.Location arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;", "public static final")]
	public partial class TypeAnnotationTarget
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypeAnnotationTarget()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CLASS_TYPE_PARAMETER", "Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "METHOD_TYPE_PARAMETER", "Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CLASS_EXTENDS", "Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CLASS_IMPLEMENTS", "Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CLASS_TYPE_PARAMETER_BOUND", "Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "METHOD_TYPE_PARAMETER_BOUND", "Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FIELD", "Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "METHOD_RETURN", "Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "METHOD_RECEIVER", "Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "METHOD_FORMAL_PARAMETER", "Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "THROWS", "Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RECORD_COMPONENT", "Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TypeAnnotationTarget", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;"));
		}

		[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;", "public static final")]
		public static Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget CLASS_TYPE_PARAMETER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;", "public static final")]
		public static Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget METHOD_TYPE_PARAMETER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;", "public static final")]
		public static Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget CLASS_EXTENDS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;", "public static final")]
		public static Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget CLASS_IMPLEMENTS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;", "public static final")]
		public static Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget CLASS_TYPE_PARAMETER_BOUND_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;", "public static final")]
		public static Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget METHOD_TYPE_PARAMETER_BOUND_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;", "public static final")]
		public static Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget FIELD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;", "public static final")]
		public static Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget METHOD_RETURN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;", "public static final")]
		public static Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget METHOD_RECEIVER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;", "public static final")]
		public static Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget METHOD_FORMAL_PARAMETER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;", "public static final")]
		public static Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget THROWS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;", "public static final")]
		public static Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget RECORD_COMPONENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;", "private static final")]
		public static JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TypeAnnotationTarget(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public TypeAnnotationTarget(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;", "public static")]
		public static JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;", "public static")]
		public static Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget>(ret);
		}

		[JniSignatureAttribute("()[Lsun/reflect/annotation/TypeAnnotation$TypeAnnotationTarget;", "private static")]
		public static JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.annotation.TypeAnnotation.TypeAnnotationTarget>>(ret);
		}
	}
}
