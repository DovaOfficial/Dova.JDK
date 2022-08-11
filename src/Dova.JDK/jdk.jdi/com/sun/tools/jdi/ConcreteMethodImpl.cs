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

namespace Dova.JDK.com.sun.tools.jdi;

[JniSignatureAttribute("Lcom/sun/tools/jdi/ConcreteMethodImpl;", "public")]
public partial class ConcreteMethodImpl
	: Dova.JDK.com.sun.tools.jdi.MethodImpl
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ConcreteMethodImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/ConcreteMethodImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "location", "Lcom/sun/jdi/Location;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "softBaseLocationXRefsRef", "Ljava/lang/ref/SoftReference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "softOtherLocationXRefsRef", "Ljava/lang/ref/SoftReference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "variablesRef", "Ljava/lang/ref/SoftReference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "absentVariableInformation", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstIndex", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastIndex", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bytecodesRef", "Ljava/lang/ref/SoftReference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argSlotCount", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jdi/VirtualMachine;Lcom/sun/tools/jdi/ReferenceTypeImpl;JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "location", "()Lcom/sun/jdi/Location;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "arguments", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocations", "(Lcom/sun/tools/jdi/SDE$Stratum;)Lcom/sun/tools/jdi/ConcreteMethodImpl$SoftLocationXRefs;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "argSlotCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "codeIndexToLineInfo", "(Lcom/sun/tools/jdi/SDE$Stratum;J)Lcom/sun/tools/jdi/LineInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allLineLocations", "(Lcom/sun/tools/jdi/SDE$Stratum;Ljava/lang/String;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locationsOfLine", "(Lcom/sun/tools/jdi/SDE$Stratum;Ljava/lang/String;I)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "variablesByName", "(Ljava/lang/String;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "variables", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locationOfCodeIndex", "(J)Lcom/sun/jdi/Location;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bytecodes", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVariables1_4", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaseLocations", "()Lcom/sun/tools/jdi/ConcreteMethodImpl$SoftLocationXRefs;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVariables1", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sourceNameFilter", "(Ljava/util/List;Lcom/sun/tools/jdi/SDE$Stratum;Ljava/lang/String;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVariables", "()Ljava/util/List;"));
	}

	[JniSignatureAttribute("Lcom/sun/jdi/Location;", "private")]
	public Dova.JDK.com.sun.jdi.Location location_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Location>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ref/SoftReference;", "private")]
	public Dova.JDK.java.lang.@ref.SoftReference softBaseLocationXRefsRef_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.SoftReference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ref/SoftReference;", "private")]
	public Dova.JDK.java.lang.@ref.SoftReference softOtherLocationXRefsRef_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.SoftReference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ref/SoftReference;", "private")]
	public Dova.JDK.java.lang.@ref.SoftReference variablesRef_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.SoftReference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool absentVariableInformation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long firstIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long lastIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ref/SoftReference;", "private")]
	public Dova.JDK.java.lang.@ref.SoftReference bytecodesRef_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.SoftReference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int argSlotCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ConcreteMethodImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/VirtualMachine;Lcom/sun/tools/jdi/ReferenceTypeImpl;JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", "")]
	public ConcreteMethodImpl(Dova.JDK.com.sun.jdi.VirtualMachine arg0, Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl arg1, long arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5, int arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/ConcreteMethodImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/jdi/Location;", "public")]
	public Dova.JDK.com.sun.jdi.Location location()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Location>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List arguments()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdi/SDE$Stratum;)Lcom/sun/tools/jdi/ConcreteMethodImpl$SoftLocationXRefs;", "private")]
	public Dova.JDK.com.sun.tools.jdi.ConcreteMethodImpl.SoftLocationXRefs getLocations(Dova.JDK.com.sun.tools.jdi.SDE.Stratum arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ConcreteMethodImpl.SoftLocationXRefs>(ret);
	}

	[JniSignatureAttribute("()I", "")]
	public int argSlotCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdi/SDE$Stratum;J)Lcom/sun/tools/jdi/LineInfo;", "")]
	public Dova.JDK.com.sun.tools.jdi.LineInfo codeIndexToLineInfo(Dova.JDK.com.sun.tools.jdi.SDE.Stratum arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.LineInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdi/SDE$Stratum;Ljava/lang/String;)Ljava/util/List;", "")]
	public Dova.JDK.java.util.List allLineLocations(Dova.JDK.com.sun.tools.jdi.SDE.Stratum arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdi/SDE$Stratum;Ljava/lang/String;I)Ljava/util/List;", "")]
	public Dova.JDK.java.util.List locationsOfLine(Dova.JDK.com.sun.tools.jdi.SDE.Stratum arg0, Dova.JDK.java.lang.String arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List variablesByName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List variables()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(J)Lcom/sun/jdi/Location;", "public")]
	public Dova.JDK.com.sun.jdi.Location locationOfCodeIndex(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Location>(ret);
	}

	[JniSignatureAttribute("()[B", "public")]
	public JavaArray<byte> bytecodes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List getVariables1_4()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/jdi/ConcreteMethodImpl$SoftLocationXRefs;", "private")]
	public Dova.JDK.com.sun.tools.jdi.ConcreteMethodImpl.SoftLocationXRefs getBaseLocations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ConcreteMethodImpl.SoftLocationXRefs>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List getVariables1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Lcom/sun/tools/jdi/SDE$Stratum;Ljava/lang/String;)Ljava/util/List;", "")]
	public Dova.JDK.java.util.List sourceNameFilter(Dova.JDK.java.util.List arg0, Dova.JDK.com.sun.tools.jdi.SDE.Stratum arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List getVariables()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/ConcreteMethodImpl$SoftLocationXRefs;", "private static")]
	public partial class SoftLocationXRefs
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SoftLocationXRefs()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/ConcreteMethodImpl$SoftLocationXRefs;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stratumID", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lineMapper", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lineLocations", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lowestLine", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "highestLine", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/util/Map;Ljava/util/List;II)V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String stratumID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "final")]
		public Dova.JDK.java.util.Map lineMapper_Property
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

		[JniSignatureAttribute("Ljava/util/List;", "final")]
		public Dova.JDK.java.util.List lineLocations_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "final")]
		public int lowestLine_Property
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

		[JniSignatureAttribute("I", "final")]
		public int highestLine_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SoftLocationXRefs(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Map;Ljava/util/List;II)V", "")]
		public SoftLocationXRefs(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.java.util.List arg2, int arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/ConcreteMethodImpl$SoftLocationXRefs;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
