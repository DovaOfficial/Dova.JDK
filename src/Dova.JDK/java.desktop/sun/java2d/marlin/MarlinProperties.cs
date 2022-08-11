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

namespace Dova.JDK.sun.java2d.marlin;

[JniSignatureAttribute("Lsun/java2d/marlin/MarlinProperties;", "public final")]
public partial class MarlinProperties
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MarlinProperties()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/marlin/MarlinProperties;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBoolean", "(Ljava/lang/String;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFloat", "(Ljava/lang/String;FFF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDouble", "(Ljava/lang/String;DDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInteger", "(Ljava/lang/String;III)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "align", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSubdividerMinLength", "()F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCurveLengthError", "()F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCubicDecD2", "()F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCubicIncD1", "()F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getQuadDecD2", "()F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isUseThreadLocal", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isLoggingEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isUseLogger", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isLogCreateContext", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isLogUnsafeMalloc", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDoStats", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDoChecks", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isUseSimplifier", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isUsePathSimplifier", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInitialPixelWidth", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInitialPixelHeight", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInitialEdges", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSubPixel_Log2_X", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSubPixel_Log2_Y", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTileSize_Log2", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTileWidth_Log2", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBlockSize_Log2", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getRLEMinWidth", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDoMonitors", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDoClipAtRuntime", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isForceRLE", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isForceNoRLE", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isUseTileFlags", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isUseTileFlagsWithHeuristics", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPathSimplifierPixelTolerance", "()F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDoClip", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDoClipRuntimeFlag", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDoClipSubdivider", "()Z"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MarlinProperties(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public MarlinProperties() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/marlin/MarlinProperties;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Z", "static")]
	public static bool getBoolean(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;FFF)F", "public static")]
	public static float getFloat(Dova.JDK.java.lang.String arg0, float arg1, float arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;DDD)D", "public static")]
	public static double getDouble(Dova.JDK.java.lang.String arg0, double arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;III)I", "static")]
	public static int getInteger(Dova.JDK.java.lang.String arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "static")]
	public static int align(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()F", "public static")]
	public static float getSubdividerMinLength()
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()F", "public static")]
	public static float getCurveLengthError()
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()F", "public static")]
	public static float getCubicDecD2()
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()F", "public static")]
	public static float getCubicIncD1()
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()F", "public static")]
	public static float getQuadDecD2()
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isUseThreadLocal()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isLoggingEnabled()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isUseLogger()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isLogCreateContext()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isLogUnsafeMalloc()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isDoStats()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isDoChecks()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isUseSimplifier()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isUsePathSimplifier()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public static")]
	public static int getInitialPixelWidth()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public static")]
	public static int getInitialPixelHeight()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public static")]
	public static int getInitialEdges()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public static")]
	public static int getSubPixel_Log2_X()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public static")]
	public static int getSubPixel_Log2_Y()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public static")]
	public static int getTileSize_Log2()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[24]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public static")]
	public static int getTileWidth_Log2()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public static")]
	public static int getBlockSize_Log2()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public static")]
	public static int getRLEMinWidth()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isDoMonitors()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[28]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isDoClipAtRuntime()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[29]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isForceRLE()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[30]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isForceNoRLE()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[31]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isUseTileFlags()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[32]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isUseTileFlagsWithHeuristics()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[33]);
		return ret;
	}

	[JniSignatureAttribute("()F", "public static")]
	public static float getPathSimplifierPixelTolerance()
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[34]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isDoClip()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[35]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isDoClipRuntimeFlag()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[36]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isDoClipSubdivider()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[37]);
		return ret;
	}
}
