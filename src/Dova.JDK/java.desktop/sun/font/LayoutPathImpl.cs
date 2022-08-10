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

namespace Dova.JDK.sun.font;

[JniSignatureAttribute("Lsun/font/LayoutPathImpl;", "public abstract")]
public partial class LayoutPathImpl
	: Dova.JDK.java.awt.font.LayoutPath
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LayoutPathImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/LayoutPathImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LOGMAP", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LOG", "Ljava/util/Formatter;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LayoutPathImpl", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "length", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "end", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getPath", "(Lsun/font/LayoutPathImpl$EndType;[D)Lsun/font/LayoutPathImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pointToPath", "(DDLjava/awt/geom/Point2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pointToPath", "(DD)Ljava/awt/geom/Point2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pathToPoint", "(DDZ)Ljava/awt/geom/Point2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pathToPoint", "(DDZLjava/awt/geom/Point2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mapShape", "(Ljava/awt/Shape;)Ljava/awt/Shape;"));
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool LOGMAP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Ljava/util/Formatter;", "private static final")]
	public static Dova.JDK.java.util.Formatter LOG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Formatter>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LayoutPathImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public LayoutPathImpl() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/font/LayoutPathImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()D", "public abstract")]
	public double length()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double start()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double end()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/font/LayoutPathImpl$EndType;[D)Lsun/font/LayoutPathImpl;", "public static transient")]
	public static Dova.JDK.sun.font.LayoutPathImpl getPath(Dova.JDK.sun.font.LayoutPathImpl.EndType arg0, JavaArray<double> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.LayoutPathImpl>(ret);
	}

	[JniSignatureAttribute("(DDLjava/awt/geom/Point2D;)V", "public")]
	public void pointToPath(double arg0, double arg1, Dova.JDK.java.awt.geom.Point2D arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(DD)Ljava/awt/geom/Point2D;", "public")]
	public Dova.JDK.java.awt.geom.Point2D pointToPath(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
	}

	[JniSignatureAttribute("(DDZ)Ljava/awt/geom/Point2D;", "public")]
	public Dova.JDK.java.awt.geom.Point2D pathToPoint(double arg0, double arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
	}

	[JniSignatureAttribute("(DDZLjava/awt/geom/Point2D;)V", "public")]
	public void pathToPoint(double arg0, double arg1, bool arg2, Dova.JDK.java.awt.geom.Point2D arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Shape;", "public abstract")]
	public Dova.JDK.java.awt.Shape mapShape(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
	}

	[JniSignatureAttribute("Lsun/font/LayoutPathImpl$SegmentPath;", "public static final")]
	public partial class SegmentPath
		: Dova.JDK.sun.font.LayoutPathImpl
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SegmentPath()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/LayoutPathImpl$SegmentPath;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "data", "[D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "etype", "Lsun/font/LayoutPathImpl$EndType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SegmentPath", "([DLsun/font/LayoutPathImpl$EndType;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "get", "(Lsun/font/LayoutPathImpl$EndType;[D)Lsun/font/LayoutPathImpl$SegmentPath;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "length", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "map", "(IDDLjava/awt/geom/Point2D;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "end", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pointToPath", "(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pathToPoint", "(Ljava/awt/geom/Point2D;ZLjava/awt/geom/Point2D;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mapShape", "(Ljava/awt/Shape;)Ljava/awt/Shape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "locateAndGetIndex", "(Ljava/awt/geom/Point2D;ZLjava/awt/geom/Point2D;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "calcoffset", "(IZLjava/awt/geom/Point2D;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getClosedAdvance", "(DZ)D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSegmentIndexForAdvance", "(DZ)I"));
		}

		[JniSignatureAttribute("[D", "private")]
		public JavaArray<double> data_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/font/LayoutPathImpl$EndType;", "")]
		public Dova.JDK.sun.font.LayoutPathImpl.EndType etype_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.font.LayoutPathImpl.EndType>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SegmentPath(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([DLsun/font/LayoutPathImpl$EndType;)V", "")]
		public SegmentPath(JavaArray<double> arg0, Dova.JDK.sun.font.LayoutPathImpl.EndType arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/font/LayoutPathImpl$SegmentPath;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/font/LayoutPathImpl$EndType;[D)Lsun/font/LayoutPathImpl$SegmentPath;", "public static transient")]
		public static Dova.JDK.sun.font.LayoutPathImpl.SegmentPath get(Dova.JDK.sun.font.LayoutPathImpl.EndType arg0, JavaArray<double> arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.font.LayoutPathImpl.SegmentPath>(ret);
		}

		[JniSignatureAttribute("()D", "public")]
		public double length()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(IDDLjava/awt/geom/Point2D;)V", "private")]
		public void map(int arg0, double arg1, double arg2, Dova.JDK.java.awt.geom.Point2D arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("()D", "public")]
		public double start()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double end()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;)Z", "public")]
		public bool pointToPath(Dova.JDK.java.awt.geom.Point2D arg0, Dova.JDK.java.awt.geom.Point2D arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/geom/Point2D;ZLjava/awt/geom/Point2D;)V", "public")]
		public void pathToPoint(Dova.JDK.java.awt.geom.Point2D arg0, bool arg1, Dova.JDK.java.awt.geom.Point2D arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Shape;", "public")]
		public Dova.JDK.java.awt.Shape mapShape(Dova.JDK.java.awt.Shape arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/geom/Point2D;ZLjava/awt/geom/Point2D;)I", "private")]
		public int locateAndGetIndex(Dova.JDK.java.awt.geom.Point2D arg0, bool arg1, Dova.JDK.java.awt.geom.Point2D arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(IZLjava/awt/geom/Point2D;)V", "private")]
		public void calcoffset(int arg0, bool arg1, Dova.JDK.java.awt.geom.Point2D arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(DZ)D", "private")]
		public double getClosedAdvance(double arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(DZ)I", "private")]
		public int getSegmentIndexForAdvance(double arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("Lsun/font/LayoutPathImpl$SegmentPath$Mapper;", "")]
		public partial class Mapper
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Mapper()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/LayoutPathImpl$SegmentPath$Mapper;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "li", "Lsun/font/LayoutPathImpl$SegmentPath$LineInfo;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "segments", "Ljava/util/ArrayList;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "mpt", "Ljava/awt/geom/Point2D$Double;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "cpt", "Ljava/awt/geom/Point2D$Double;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "haveMT", "Z"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Mapper", "(Lsun/font/LayoutPathImpl$SegmentPath;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "init", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "close", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mapShape", "(Ljava/awt/Shape;)Ljava/awt/Shape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "moveTo", "(DD)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "lineTo", "(DD)V"));
			}

			[JniSignatureAttribute("Lsun/font/LayoutPathImpl$SegmentPath$LineInfo;", "final")]
			public Dova.JDK.sun.font.LayoutPathImpl.SegmentPath.LineInfo li_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.sun.font.LayoutPathImpl.SegmentPath.LineInfo>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljava/util/ArrayList;", "final")]
			public Dova.JDK.java.util.ArrayList segments_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljava/awt/geom/Point2D$Double;", "final")]
			public Dova.JDK.java.awt.geom.Point2D.Double mpt_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D.Double>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljava/awt/geom/Point2D$Double;", "final")]
			public Dova.JDK.java.awt.geom.Point2D.Double cpt_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D.Double>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Z", "")]
			public bool haveMT_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
					return ret;
				}
				set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Mapper(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/font/LayoutPathImpl$SegmentPath;)V", "")]
			public Mapper(Dova.JDK.sun.font.LayoutPathImpl.SegmentPath arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/font/LayoutPathImpl$SegmentPath$Mapper;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "")]
			public void init()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("()V", "")]
			public void close()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
			}

			[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Shape;", "public")]
			public Dova.JDK.java.awt.Shape mapShape(Dova.JDK.java.awt.Shape arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
			}

			[JniSignatureAttribute("(DD)V", "")]
			public void moveTo(double arg0, double arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			}

			[JniSignatureAttribute("(DD)V", "")]
			public void lineTo(double arg0, double arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			}
		}

		[JniSignatureAttribute("Lsun/font/LayoutPathImpl$SegmentPath$Segment;", "")]
		public partial class Segment
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Segment()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/LayoutPathImpl$SegmentPath$Segment;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "ix", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "ux", "D"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "uy", "D"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "temp", "Lsun/font/LayoutPathImpl$SegmentPath$LineInfo;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "broken", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "cx", "D"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "cy", "D"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "gp", "Ljava/awt/geom/GeneralPath;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Lsun/font/LayoutPathImpl$SegmentPath;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Segment", "(Lsun/font/LayoutPathImpl$SegmentPath;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "line", "(Lsun/font/LayoutPathImpl$SegmentPath$LineInfo;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "init", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "close", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "move", "()V"));
			}

			[JniSignatureAttribute("I", "final")]
			public int ix_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
					return ret;
				}
				set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}

			[JniSignatureAttribute("D", "final")]
			public double ux_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[1], value);
			}

			[JniSignatureAttribute("D", "final")]
			public double uy_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[2], value);
			}

			[JniSignatureAttribute("Lsun/font/LayoutPathImpl$SegmentPath$LineInfo;", "final")]
			public Dova.JDK.sun.font.LayoutPathImpl.SegmentPath.LineInfo temp_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.sun.font.LayoutPathImpl.SegmentPath.LineInfo>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Z", "")]
			public bool broken_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
					return ret;
				}
				set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
			}

			[JniSignatureAttribute("D", "")]
			public double cx_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[5]);
					return ret;
				}
				set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[5], value);
			}

			[JniSignatureAttribute("D", "")]
			public double cy_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[6]);
					return ret;
				}
				set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[6], value);
			}

			[JniSignatureAttribute("Ljava/awt/geom/GeneralPath;", "")]
			public Dova.JDK.java.awt.geom.GeneralPath gp_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.GeneralPath>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Lsun/font/LayoutPathImpl$SegmentPath;", "final")]
			public Dova.JDK.sun.font.LayoutPathImpl.SegmentPath this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
					return DovaInterfaceFactory.Get<Dova.JDK.sun.font.LayoutPathImpl.SegmentPath>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Segment(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/font/LayoutPathImpl$SegmentPath;I)V", "")]
			public Segment(Dova.JDK.sun.font.LayoutPathImpl.SegmentPath arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/font/LayoutPathImpl$SegmentPath$Segment;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lsun/font/LayoutPathImpl$SegmentPath$LineInfo;)V", "")]
			public void line(Dova.JDK.sun.font.LayoutPathImpl.SegmentPath.LineInfo arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("()V", "")]
			public void init()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
			}

			[JniSignatureAttribute("()V", "")]
			public void close()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
			}

			[JniSignatureAttribute("()V", "")]
			public void move()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
			}
		}

		[JniSignatureAttribute("Lsun/font/LayoutPathImpl$SegmentPath$LineInfo;", "")]
		public partial class LineInfo
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static LineInfo()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/LayoutPathImpl$SegmentPath$LineInfo;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "sx", "D"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "sy", "D"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lx", "D"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "ly", "D"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "m", "D"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Lsun/font/LayoutPathImpl$SegmentPath;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LineInfo", "(Lsun/font/LayoutPathImpl$SegmentPath;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "set", "(Lsun/font/LayoutPathImpl$SegmentPath$LineInfo;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "set", "(DDDD)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pin", "(DDLsun/font/LayoutPathImpl$SegmentPath$LineInfo;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pin", "(ILsun/font/LayoutPathImpl$SegmentPath$LineInfo;)Z"));
			}

			[JniSignatureAttribute("D", "")]
			public double sx_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[0]);
					return ret;
				}
				set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[0], value);
			}

			[JniSignatureAttribute("D", "")]
			public double sy_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[1], value);
			}

			[JniSignatureAttribute("D", "")]
			public double lx_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[2], value);
			}

			[JniSignatureAttribute("D", "")]
			public double ly_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[3]);
					return ret;
				}
				set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[3], value);
			}

			[JniSignatureAttribute("D", "")]
			public double m_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[4]);
					return ret;
				}
				set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[4], value);
			}

			[JniSignatureAttribute("Lsun/font/LayoutPathImpl$SegmentPath;", "final")]
			public Dova.JDK.sun.font.LayoutPathImpl.SegmentPath this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.sun.font.LayoutPathImpl.SegmentPath>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public LineInfo(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/font/LayoutPathImpl$SegmentPath;)V", "")]
			public LineInfo(Dova.JDK.sun.font.LayoutPathImpl.SegmentPath arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/font/LayoutPathImpl$SegmentPath$LineInfo;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lsun/font/LayoutPathImpl$SegmentPath$LineInfo;)V", "")]
			public void set(Dova.JDK.sun.font.LayoutPathImpl.SegmentPath.LineInfo arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(DDDD)V", "")]
			public void set(double arg0, double arg1, double arg2, double arg3)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
			}

			[JniSignatureAttribute("(DDLsun/font/LayoutPathImpl$SegmentPath$LineInfo;)Z", "")]
			public bool pin(double arg0, double arg1, Dova.JDK.sun.font.LayoutPathImpl.SegmentPath.LineInfo arg2)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return ret;
			}

			[JniSignatureAttribute("(ILsun/font/LayoutPathImpl$SegmentPath$LineInfo;)Z", "")]
			public bool pin(int arg0, Dova.JDK.sun.font.LayoutPathImpl.SegmentPath.LineInfo arg1)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lsun/font/LayoutPathImpl$EndType;", "public static final")]
	public partial class EndType
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EndType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/LayoutPathImpl$EndType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PINNED", "Lsun/font/LayoutPathImpl$EndType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXTENDED", "Lsun/font/LayoutPathImpl$EndType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CLOSED", "Lsun/font/LayoutPathImpl$EndType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lsun/font/LayoutPathImpl$EndType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "EndType", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lsun/font/LayoutPathImpl$EndType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lsun/font/LayoutPathImpl$EndType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lsun/font/LayoutPathImpl$EndType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isClosed", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isPinned", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isExtended", "()Z"));
		}

		[JniSignatureAttribute("Lsun/font/LayoutPathImpl$EndType;", "public static final")]
		public static Dova.JDK.sun.font.LayoutPathImpl.EndType PINNED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.font.LayoutPathImpl.EndType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/font/LayoutPathImpl$EndType;", "public static final")]
		public static Dova.JDK.sun.font.LayoutPathImpl.EndType EXTENDED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.font.LayoutPathImpl.EndType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/font/LayoutPathImpl$EndType;", "public static final")]
		public static Dova.JDK.sun.font.LayoutPathImpl.EndType CLOSED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.font.LayoutPathImpl.EndType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Lsun/font/LayoutPathImpl$EndType;", "private static final")]
		public static JavaArray<Dova.JDK.sun.font.LayoutPathImpl.EndType> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.font.LayoutPathImpl.EndType>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EndType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public EndType(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/font/LayoutPathImpl$EndType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/font/LayoutPathImpl$EndType;", "public static")]
		public static JavaArray<Dova.JDK.sun.font.LayoutPathImpl.EndType> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.font.LayoutPathImpl.EndType>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/font/LayoutPathImpl$EndType;", "public static")]
		public static Dova.JDK.sun.font.LayoutPathImpl.EndType valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.font.LayoutPathImpl.EndType>(ret);
		}

		[JniSignatureAttribute("()[Lsun/font/LayoutPathImpl$EndType;", "private static")]
		public static JavaArray<Dova.JDK.sun.font.LayoutPathImpl.EndType> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.font.LayoutPathImpl.EndType>>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isClosed()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPinned()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isExtended()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/font/LayoutPathImpl$EmptyPath;", "public static")]
	public partial class EmptyPath
		: Dova.JDK.sun.font.LayoutPathImpl
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EmptyPath()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/LayoutPathImpl$EmptyPath;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "tx", "Ljava/awt/geom/AffineTransform;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "EmptyPath", "(Ljava/awt/geom/AffineTransform;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "length", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "end", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pointToPath", "(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pathToPoint", "(Ljava/awt/geom/Point2D;ZLjava/awt/geom/Point2D;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mapShape", "(Ljava/awt/Shape;)Ljava/awt/Shape;"));
		}

		[JniSignatureAttribute("Ljava/awt/geom/AffineTransform;", "private")]
		public Dova.JDK.java.awt.geom.AffineTransform tx_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EmptyPath(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;)V", "public")]
		public EmptyPath(Dova.JDK.java.awt.geom.AffineTransform arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/font/LayoutPathImpl$EmptyPath;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()D", "public")]
		public double length()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double start()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double end()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;)Z", "public")]
		public bool pointToPath(Dova.JDK.java.awt.geom.Point2D arg0, Dova.JDK.java.awt.geom.Point2D arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/geom/Point2D;ZLjava/awt/geom/Point2D;)V", "public")]
		public void pathToPoint(Dova.JDK.java.awt.geom.Point2D arg0, bool arg1, Dova.JDK.java.awt.geom.Point2D arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Shape;", "public")]
		public Dova.JDK.java.awt.Shape mapShape(Dova.JDK.java.awt.Shape arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/font/LayoutPathImpl$SegmentPathBuilder;", "public static final")]
	public partial class SegmentPathBuilder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SegmentPathBuilder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/LayoutPathImpl$SegmentPathBuilder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "data", "[D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "w", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "px", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "py", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "a", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "pconnect", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SegmentPathBuilder", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reset", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "build", "(Lsun/font/LayoutPathImpl$EndType;[D)Lsun/font/LayoutPathImpl$SegmentPath;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "complete", "(Lsun/font/LayoutPathImpl$EndType;)Lsun/font/LayoutPathImpl$SegmentPath;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "complete", "()Lsun/font/LayoutPathImpl$SegmentPath;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextPoint", "(DDZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "moveTo", "(DD)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "lineTo", "(DD)V"));
		}

		[JniSignatureAttribute("[D", "private")]
		public JavaArray<double> data_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "private")]
		public int w_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("D", "private")]
		public double px_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("D", "private")]
		public double py_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("D", "private")]
		public double a_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("Z", "private")]
		public bool pconnect_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[6], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SegmentPathBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public SegmentPathBuilder() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/font/LayoutPathImpl$SegmentPathBuilder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)V", "public")]
		public void reset(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lsun/font/LayoutPathImpl$EndType;[D)Lsun/font/LayoutPathImpl$SegmentPath;", "public transient")]
		public Dova.JDK.sun.font.LayoutPathImpl.SegmentPath build(Dova.JDK.sun.font.LayoutPathImpl.EndType arg0, JavaArray<double> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.font.LayoutPathImpl.SegmentPath>(ret);
		}

		[JniSignatureAttribute("(Lsun/font/LayoutPathImpl$EndType;)Lsun/font/LayoutPathImpl$SegmentPath;", "public")]
		public Dova.JDK.sun.font.LayoutPathImpl.SegmentPath complete(Dova.JDK.sun.font.LayoutPathImpl.EndType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.font.LayoutPathImpl.SegmentPath>(ret);
		}

		[JniSignatureAttribute("()Lsun/font/LayoutPathImpl$SegmentPath;", "public")]
		public Dova.JDK.sun.font.LayoutPathImpl.SegmentPath complete()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.font.LayoutPathImpl.SegmentPath>(ret);
		}

		[JniSignatureAttribute("(DDZ)V", "private")]
		public void nextPoint(double arg0, double arg1, bool arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(DD)V", "public")]
		public void moveTo(double arg0, double arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		}

		[JniSignatureAttribute("(DD)V", "public")]
		public void lineTo(double arg0, double arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		}
	}
}
