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

namespace Dova.JDK.sun.security.ssl;

[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "final")]
public partial class CipherSuite
	: Dova.JDK.java.lang.Enum
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CipherSuite()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/CipherSuite;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_AES_256_GCM_SHA384", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_AES_128_GCM_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_CHACHA20_POLY1305_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_DHE_RSA_WITH_AES_256_GCM_SHA384", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_DHE_DSS_WITH_AES_256_GCM_SHA384", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_DHE_RSA_WITH_AES_128_GCM_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_DHE_DSS_WITH_AES_128_GCM_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_DHE_RSA_WITH_AES_256_CBC_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_DHE_DSS_WITH_AES_256_CBC_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_DHE_RSA_WITH_AES_128_CBC_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_DHE_DSS_WITH_AES_128_CBC_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_DHE_RSA_WITH_AES_256_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_DHE_DSS_WITH_AES_256_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_DHE_RSA_WITH_AES_128_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_DHE_DSS_WITH_AES_128_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_RSA_WITH_AES_256_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_RSA_WITH_AES_128_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_RSA_WITH_AES_256_GCM_SHA384", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_RSA_WITH_AES_128_GCM_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_RSA_WITH_AES_256_CBC_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_RSA_WITH_AES_128_CBC_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_RSA_WITH_AES_256_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_RSA_WITH_AES_128_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SSL_DHE_RSA_WITH_3DES_EDE_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SSL_DHE_DSS_WITH_3DES_EDE_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SSL_RSA_WITH_3DES_EDE_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_EMPTY_RENEGOTIATION_INFO_SCSV", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_DH_anon_WITH_AES_256_GCM_SHA384", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_DH_anon_WITH_AES_128_GCM_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_DH_anon_WITH_AES_256_CBC_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_anon_WITH_AES_256_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_DH_anon_WITH_AES_256_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_DH_anon_WITH_AES_128_CBC_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_anon_WITH_AES_128_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_DH_anon_WITH_AES_128_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SSL_DH_anon_WITH_3DES_EDE_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDHE_ECDSA_WITH_RC4_128_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDHE_RSA_WITH_RC4_128_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SSL_RSA_WITH_RC4_128_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_ECDSA_WITH_RC4_128_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_RSA_WITH_RC4_128_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SSL_RSA_WITH_RC4_128_MD5", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_anon_WITH_RC4_128_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SSL_DH_anon_WITH_RC4_128_MD5", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SSL_RSA_WITH_DES_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SSL_DHE_RSA_WITH_DES_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SSL_DHE_DSS_WITH_DES_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SSL_DH_anon_WITH_DES_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SSL_RSA_EXPORT_WITH_DES40_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SSL_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SSL_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SSL_DH_anon_EXPORT_WITH_DES40_CBC_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SSL_RSA_EXPORT_WITH_RC4_40_MD5", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SSL_DH_anon_EXPORT_WITH_RC4_40_MD5", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_RSA_WITH_NULL_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDHE_ECDSA_WITH_NULL_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDHE_RSA_WITH_NULL_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SSL_RSA_WITH_NULL_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_ECDSA_WITH_NULL_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_RSA_WITH_NULL_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_ECDH_anon_WITH_NULL_SHA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SSL_RSA_WITH_NULL_MD5", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_AES_128_CCM_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TLS_AES_128_CCM_8_SHA256", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0006", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0007", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_000B", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_000C", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_000D", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_000E", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_000F", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0010", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_001C", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_001D", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0062", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0063", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0064", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0065", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0066", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_FFE0", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_FFE1", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_FEFE", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_FEFF", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_001E", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_001F", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0020", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0021", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0022", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0023", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0024", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0025", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0026", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0027", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0028", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0029", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_002A", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_002B", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0096", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0097", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0098", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0099", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_009A", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_009B", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_008A", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_008B", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_008C", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_008D", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_008E", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_008F", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0090", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0091", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0092", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0093", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0094", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0095", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_002C", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_002D", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_002E", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0030", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0031", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0036", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0037", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_003E", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_003F", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0068", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0069", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00A0", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00A1", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00A4", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00A5", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00A8", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00A9", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00AA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00AB", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00AC", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00AD", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00AE", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00AF", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00B0", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00B1", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00B2", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00B3", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00B4", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00B5", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00B6", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00B7", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00B8", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00B9", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0041", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0042", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0043", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0044", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0045", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0046", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0084", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0085", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0086", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0087", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0088", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_0089", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00BA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00BB", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00BC", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00BD", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00BE", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00BF", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00C0", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00C1", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00C2", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00C3", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00C4", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_00C5", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_5600", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C01A", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C01B", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C01C", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C01D", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C01E", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C01F", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C020", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C021", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C022", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C033", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C034", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C035", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C036", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C037", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C038", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C039", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C03A", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C03B", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C03C", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C03D", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C03E", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C03F", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C040", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C041", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C042", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C043", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C044", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C045", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C046", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C047", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C048", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C049", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C04A", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C04B", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C04C", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C04D", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C04E", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C04F", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C050", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C051", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C052", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C053", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C054", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C055", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C056", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C057", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C058", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C059", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C05A", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C05B", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C05C", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C05D", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C05E", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C05F", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C060", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C061", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C062", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C063", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C064", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C065", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C066", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C067", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C068", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C069", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C06A", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C06B", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C06C", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C06D", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C06E", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C06F", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C070", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C071", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C072", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C073", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C074", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C075", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C076", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C077", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C078", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C079", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C07A", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C07B", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C07C", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C07D", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C07E", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C07F", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C080", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C081", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C082", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C083", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C084", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C085", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C086", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C087", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C088", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C089", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C08A", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C08B", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C08C", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C08D", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C08E", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C08F", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C090", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C091", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C092", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C093", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C094", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C095", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C096", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C097", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C098", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C099", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C09A", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C09B", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C09C", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C09D", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C09E", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C09F", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C0A0", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C0A1", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C0A2", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C0A3", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C0A4", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C0A5", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C0A6", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C0A7", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C0A8", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C0A9", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C0AA", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C0AB", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C0AC", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C0AD", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C0AE", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CS_C0AF", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "C_NULL", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "id", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isDefaultEnabled", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "aliases", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "supportedProtocols", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyExchange", "Lsun/security/ssl/CipherSuite$KeyExchange;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bulkCipher", "Lsun/security/ssl/SSLCipher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "macAlg", "Lsun/security/ssl/CipherSuite$MacAlg;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashAlg", "Lsun/security/ssl/CipherSuite$HashAlg;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exportable", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "cipherSuiteIds", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "cipherSuiteNames", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "allowedCipherSuites", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultCipherSuites", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/security/ssl/CipherSuite;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IIZLjava/lang/String;[Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Lsun/security/ssl/CipherSuite$HashAlg;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IIZLjava/lang/String;Ljava/lang/String;[Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/CipherSuite$KeyExchange;Lsun/security/ssl/SSLCipher;Lsun/security/ssl/CipherSuite$MacAlg;Lsun/security/ssl/CipherSuite$HashAlg;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/security/ssl/CipherSuite;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/ssl/CipherSuite;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(I)Lsun/security/ssl/CipherSuite;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/security/ssl/CipherSuite;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nameOf", "(Ljava/lang/String;)Lsun/security/ssl/CipherSuite;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nameOf", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNegotiable", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "namesOf", "(Ljava/util/List;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supports", "(Lsun/security/ssl/ProtocolVersion;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnonymous", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "allowedCipherSuites", "()Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "defaultCipherSuites", "()Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "validValuesOf", "([Ljava/lang/String;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculatePacketSize", "(ILsun/security/ssl/ProtocolVersion;Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateFragSize", "(ILsun/security/ssl/ProtocolVersion;Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAvailable", "()Z"));
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_AES_256_GCM_SHA384_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_AES_128_GCM_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_CHACHA20_POLY1305_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_DHE_RSA_WITH_AES_256_GCM_SHA384_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_DHE_DSS_WITH_AES_256_GCM_SHA384_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_DHE_RSA_WITH_AES_128_GCM_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_DHE_DSS_WITH_AES_128_GCM_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_DHE_RSA_WITH_AES_256_CBC_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_DHE_DSS_WITH_AES_256_CBC_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_DHE_RSA_WITH_AES_128_CBC_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_DHE_DSS_WITH_AES_128_CBC_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_DHE_RSA_WITH_AES_256_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_DHE_DSS_WITH_AES_256_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_DHE_RSA_WITH_AES_128_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_DHE_DSS_WITH_AES_128_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_RSA_WITH_AES_256_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_RSA_WITH_AES_128_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_RSA_WITH_AES_256_GCM_SHA384_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_RSA_WITH_AES_128_GCM_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_RSA_WITH_AES_256_CBC_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_RSA_WITH_AES_128_CBC_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_RSA_WITH_AES_256_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_RSA_WITH_AES_128_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite SSL_DHE_RSA_WITH_3DES_EDE_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite SSL_DHE_DSS_WITH_3DES_EDE_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite SSL_RSA_WITH_3DES_EDE_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_EMPTY_RENEGOTIATION_INFO_SCSV_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[55]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[55], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_DH_anon_WITH_AES_256_GCM_SHA384_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[56]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[56], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_DH_anon_WITH_AES_128_GCM_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_DH_anon_WITH_AES_256_CBC_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_anon_WITH_AES_256_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_DH_anon_WITH_AES_256_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_DH_anon_WITH_AES_128_CBC_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[61]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[61], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_anon_WITH_AES_128_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[62]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[62], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_DH_anon_WITH_AES_128_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[63]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[63], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite SSL_DH_anon_WITH_3DES_EDE_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDHE_ECDSA_WITH_RC4_128_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDHE_RSA_WITH_RC4_128_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite SSL_RSA_WITH_RC4_128_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[68]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[68], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_ECDSA_WITH_RC4_128_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[69]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[69], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_RSA_WITH_RC4_128_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite SSL_RSA_WITH_RC4_128_MD5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[71]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[71], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_anon_WITH_RC4_128_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[72]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[72], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite SSL_DH_anon_WITH_RC4_128_MD5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[73]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[73], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite SSL_RSA_WITH_DES_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[74]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[74], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite SSL_DHE_RSA_WITH_DES_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[75]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[75], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite SSL_DHE_DSS_WITH_DES_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[76]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[76], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite SSL_DH_anon_WITH_DES_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[77]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[77], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite SSL_RSA_EXPORT_WITH_DES40_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[78]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[78], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite SSL_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[79]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[79], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite SSL_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[80]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[80], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite SSL_DH_anon_EXPORT_WITH_DES40_CBC_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[81]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[81], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite SSL_RSA_EXPORT_WITH_RC4_40_MD5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[82]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[82], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite SSL_DH_anon_EXPORT_WITH_RC4_40_MD5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[83]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[83], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_RSA_WITH_NULL_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[84]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[84], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDHE_ECDSA_WITH_NULL_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[85]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[85], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDHE_RSA_WITH_NULL_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[86]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[86], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite SSL_RSA_WITH_NULL_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[87]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[87], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_ECDSA_WITH_NULL_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[88]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[88], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_RSA_WITH_NULL_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[89]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[89], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_ECDH_anon_WITH_NULL_SHA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[90]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[90], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite SSL_RSA_WITH_NULL_MD5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[91]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[91], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_AES_128_CCM_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[92]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[92], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite TLS_AES_128_CCM_8_SHA256_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[93]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[93], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0006_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[94]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[94], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0007_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[95]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[95], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_000B_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[96]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[96], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_000C_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[97]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[97], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_000D_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[98]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[98], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_000E_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[99]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[99], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_000F_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[100]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[100], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0010_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[101]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[101], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_001C_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[102]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[102], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_001D_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[103]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[103], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0062_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[104]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[104], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0063_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[105]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[105], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0064_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[106]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[106], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0065_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[107]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[107], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0066_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[108]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[108], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_FFE0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[109]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[109], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_FFE1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[110]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[110], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_FEFE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[111]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[111], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_FEFF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[112]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[112], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_001E_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[113]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[113], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_001F_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[114]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[114], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0020_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[115]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[115], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0021_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[116]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[116], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0022_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[117]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[117], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0023_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[118]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[118], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0024_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[119]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[119], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0025_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[120]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[120], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0026_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[121]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[121], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0027_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[122]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[122], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0028_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[123]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[123], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0029_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[124]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[124], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_002A_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[125]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[125], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_002B_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[126]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[126], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0096_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[127]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[127], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0097_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[128]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[128], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0098_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[129]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[129], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0099_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[130]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[130], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_009A_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[131]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[131], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_009B_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[132]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[132], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_008A_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[133]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[133], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_008B_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[134]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[134], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_008C_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[135]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[135], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_008D_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[136]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[136], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_008E_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[137]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[137], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_008F_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[138]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[138], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0090_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[139]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[139], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0091_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[140]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[140], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0092_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[141]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[141], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0093_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[142]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[142], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0094_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[143]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[143], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0095_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[144]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[144], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_002C_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[145]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[145], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_002D_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[146]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[146], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_002E_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[147]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[147], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0030_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[148]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[148], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0031_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[149]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[149], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0036_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[150]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[150], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0037_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[151]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[151], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_003E_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[152]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[152], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_003F_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[153]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[153], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0068_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[154]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[154], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0069_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[155]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[155], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00A0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[156]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[156], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00A1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[157]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[157], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00A4_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[158]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[158], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00A5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[159]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[159], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00A8_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[160]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[160], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00A9_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[161]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[161], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00AA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[162]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[162], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00AB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[163]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[163], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00AC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[164]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[164], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00AD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[165]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[165], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00AE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[166]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[166], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00AF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[167]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[167], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00B0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[168]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[168], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00B1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[169]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[169], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00B2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[170]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[170], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00B3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[171]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[171], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00B4_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[172]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[172], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00B5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[173]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[173], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00B6_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[174]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[174], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00B7_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[175]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[175], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00B8_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[176]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[176], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00B9_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[177]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[177], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0041_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[178]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[178], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0042_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[179]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[179], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0043_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[180]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[180], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0044_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[181]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[181], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0045_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[182]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[182], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0046_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[183]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[183], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0084_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[184]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[184], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0085_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[185]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[185], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0086_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[186]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[186], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0087_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[187]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[187], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0088_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[188]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[188], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_0089_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[189]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[189], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00BA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[190]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[190], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00BB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[191]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[191], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00BC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[192]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[192], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00BD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[193]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[193], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00BE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[194]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[194], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00BF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[195]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[195], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00C0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[196]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[196], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00C1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[197]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[197], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00C2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[198]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[198], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00C3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[199]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[199], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00C4_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[200]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[200], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_00C5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[201]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[201], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_5600_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[202]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[202], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C01A_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[203]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[203], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C01B_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[204]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[204], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C01C_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[205]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[205], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C01D_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[206]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[206], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C01E_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[207]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[207], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C01F_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[208]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[208], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C020_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[209]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[209], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C021_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[210]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[210], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C022_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[211]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[211], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C033_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[212]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[212], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C034_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[213]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[213], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C035_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[214]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[214], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C036_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[215]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[215], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C037_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[216]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[216], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C038_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[217]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[217], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C039_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[218]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[218], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C03A_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[219]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[219], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C03B_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[220]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[220], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C03C_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[221]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[221], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C03D_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[222]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[222], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C03E_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[223]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[223], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C03F_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[224]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[224], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C040_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[225]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[225], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C041_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[226]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[226], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C042_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[227]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[227], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C043_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[228]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[228], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C044_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[229]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[229], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C045_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[230]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[230], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C046_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[231]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[231], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C047_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[232]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[232], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C048_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[233]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[233], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C049_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[234]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[234], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C04A_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[235]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[235], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C04B_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[236]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[236], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C04C_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[237]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[237], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C04D_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[238]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[238], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C04E_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[239]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[239], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C04F_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[240]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[240], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C050_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[241]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[241], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C051_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[242]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[242], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C052_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[243]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[243], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C053_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[244]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[244], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C054_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[245]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[245], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C055_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[246]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[246], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C056_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[247]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[247], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C057_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[248]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[248], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C058_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[249]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[249], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C059_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[250]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[250], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C05A_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[251]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[251], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C05B_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[252]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[252], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C05C_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[253]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[253], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C05D_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[254]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[254], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C05E_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[255]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[255], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C05F_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[256]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[256], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C060_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[257]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[257], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C061_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[258]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[258], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C062_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[259]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[259], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C063_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[260]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[260], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C064_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[261]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[261], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C065_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[262]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[262], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C066_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[263]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[263], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C067_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[264]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[264], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C068_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[265]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[265], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C069_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[266]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[266], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C06A_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[267]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[267], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C06B_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[268]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[268], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C06C_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[269]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[269], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C06D_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[270]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[270], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C06E_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[271]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[271], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C06F_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[272]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[272], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C070_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[273]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[273], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C071_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[274]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[274], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C072_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[275]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[275], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C073_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[276]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[276], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C074_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[277]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[277], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C075_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[278]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[278], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C076_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[279]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[279], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C077_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[280]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[280], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C078_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[281]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[281], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C079_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[282]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[282], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C07A_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[283]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[283], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C07B_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[284]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[284], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C07C_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[285]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[285], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C07D_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[286]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[286], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C07E_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[287]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[287], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C07F_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[288]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[288], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C080_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[289]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[289], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C081_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[290]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[290], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C082_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[291]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[291], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C083_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[292]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[292], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C084_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[293]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[293], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C085_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[294]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[294], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C086_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[295]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[295], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C087_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[296]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[296], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C088_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[297]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[297], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C089_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[298]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[298], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C08A_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[299]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[299], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C08B_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[300]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[300], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C08C_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[301]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[301], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C08D_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[302]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[302], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C08E_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[303]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[303], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C08F_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[304]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[304], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C090_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[305]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[305], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C091_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[306]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[306], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C092_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[307]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[307], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C093_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[308]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[308], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C094_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[309]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[309], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C095_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[310]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[310], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C096_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[311]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[311], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C097_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[312]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[312], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C098_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[313]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[313], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C099_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[314]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[314], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C09A_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[315]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[315], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C09B_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[316]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[316], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C09C_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[317]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[317], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C09D_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[318]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[318], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C09E_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[319]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[319], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C09F_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[320]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[320], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C0A0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[321]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[321], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C0A1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[322]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[322], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C0A2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[323]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[323], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C0A3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[324]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[324], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C0A4_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[325]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[325], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C0A5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[326]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[326], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C0A6_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[327]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[327], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C0A7_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[328]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[328], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C0A8_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[329]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[329], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C0A9_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[330]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[330], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C0AA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[331]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[331], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C0AB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[332]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[332], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C0AC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[333]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[333], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C0AD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[334]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[334], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C0AE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[335]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[335], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite CS_C0AF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[336]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[336], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "public static final")]
	public static Dova.JDK.sun.security.ssl.CipherSuite C_NULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[337]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[337], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "final")]
	public int id_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[338]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[338], value);
		}
	}

	[JniSignatureAttribute("Z", "final")]
	public bool isDefaultEnabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[339]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[339], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[340]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[340], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "final")]
	public Dova.JDK.java.util.List aliases_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[341]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[341], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "final")]
	public Dova.JDK.java.util.List supportedProtocols_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[342]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[342], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$KeyExchange;", "final")]
	public Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange keyExchange_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[343]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[343], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLCipher;", "final")]
	public Dova.JDK.sun.security.ssl.SSLCipher bulkCipher_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[344]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLCipher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[344], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$MacAlg;", "final")]
	public Dova.JDK.sun.security.ssl.CipherSuite.MacAlg macAlg_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[345]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.MacAlg>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[345], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$HashAlg;", "final")]
	public Dova.JDK.sun.security.ssl.CipherSuite.HashAlg hashAlg_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[346]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.HashAlg>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[346], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "final")]
	public bool exportable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[347]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[347], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map cipherSuiteIds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[348]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[348], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map cipherSuiteNames_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[349]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[349], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private static final")]
	public static Dova.JDK.java.util.List allowedCipherSuites_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[350]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[350], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private static final")]
	public static Dova.JDK.java.util.List defaultCipherSuites_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[351]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[351], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/CipherSuite;", "private static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.CipherSuite> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[352]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.CipherSuite>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[352], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CipherSuite(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;IIZLjava/lang/String;[Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/SSLCipher;Lsun/security/ssl/CipherSuite$HashAlg;)V", "private")]
	public CipherSuite(Dova.JDK.java.lang.String arg0, int arg1, int arg2, bool arg3, Dova.JDK.java.lang.String arg4, JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> arg5, Dova.JDK.sun.security.ssl.SSLCipher arg6, Dova.JDK.sun.security.ssl.CipherSuite.HashAlg arg7) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;IIZLjava/lang/String;Ljava/lang/String;[Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/CipherSuite$KeyExchange;Lsun/security/ssl/SSLCipher;Lsun/security/ssl/CipherSuite$MacAlg;Lsun/security/ssl/CipherSuite$HashAlg;)V", "private")]
	public CipherSuite(Dova.JDK.java.lang.String arg0, int arg1, int arg2, bool arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5, JavaArray<Dova.JDK.sun.security.ssl.ProtocolVersion> arg6, Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange arg7, Dova.JDK.sun.security.ssl.SSLCipher arg8, Dova.JDK.sun.security.ssl.CipherSuite.MacAlg arg9, Dova.JDK.sun.security.ssl.CipherSuite.HashAlg arg10) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;I)V", "private")]
	public CipherSuite(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/CipherSuite;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lsun/security/ssl/CipherSuite;", "public static")]
	public static JavaArray<Dova.JDK.sun.security.ssl.CipherSuite> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.CipherSuite>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/ssl/CipherSuite;", "public static")]
	public static Dova.JDK.sun.security.ssl.CipherSuite valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
	}

	[JniSignatureAttribute("(I)Lsun/security/ssl/CipherSuite;", "static")]
	public static Dova.JDK.sun.security.ssl.CipherSuite valueOf(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
	}

	[JniSignatureAttribute("()[Lsun/security/ssl/CipherSuite;", "private static")]
	public static JavaArray<Dova.JDK.sun.security.ssl.CipherSuite> _values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.CipherSuite>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/ssl/CipherSuite;", "static")]
	public static Dova.JDK.sun.security.ssl.CipherSuite nameOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String nameOf(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isNegotiable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;)[Ljava/lang/String;", "static")]
	public static JavaArray<Dova.JDK.java.lang.String> namesOf(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/ProtocolVersion;)Z", "public")]
	public bool supports(Dova.JDK.sun.security.ssl.ProtocolVersion arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isAnonymous()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Collection;", "static")]
	public static Dova.JDK.java.util.Collection allowedCipherSuites()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Collection;", "static")]
	public static Dova.JDK.java.util.Collection defaultCipherSuites()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)Ljava/util/List;", "static")]
	public static Dova.JDK.java.util.List validValuesOf(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(ILsun/security/ssl/ProtocolVersion;Z)I", "")]
	public int calculatePacketSize(int arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(ILsun/security/ssl/ProtocolVersion;Z)I", "")]
	public int calculateFragSize(int arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isAvailable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$KeyExchange;", "static final")]
	public partial class KeyExchange
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static KeyExchange()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/CipherSuite$KeyExchange;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "K_NULL", "Lsun/security/ssl/CipherSuite$KeyExchange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "K_RSA", "Lsun/security/ssl/CipherSuite$KeyExchange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "K_RSA_EXPORT", "Lsun/security/ssl/CipherSuite$KeyExchange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "K_DH_RSA", "Lsun/security/ssl/CipherSuite$KeyExchange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "K_DH_DSS", "Lsun/security/ssl/CipherSuite$KeyExchange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "K_DHE_DSS", "Lsun/security/ssl/CipherSuite$KeyExchange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "K_DHE_DSS_EXPORT", "Lsun/security/ssl/CipherSuite$KeyExchange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "K_DHE_RSA", "Lsun/security/ssl/CipherSuite$KeyExchange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "K_DHE_RSA_EXPORT", "Lsun/security/ssl/CipherSuite$KeyExchange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "K_DH_ANON", "Lsun/security/ssl/CipherSuite$KeyExchange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "K_DH_ANON_EXPORT", "Lsun/security/ssl/CipherSuite$KeyExchange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "K_ECDH_ECDSA", "Lsun/security/ssl/CipherSuite$KeyExchange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "K_ECDH_RSA", "Lsun/security/ssl/CipherSuite$KeyExchange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "K_ECDHE_ECDSA", "Lsun/security/ssl/CipherSuite$KeyExchange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "K_ECDHE_RSA", "Lsun/security/ssl/CipherSuite$KeyExchange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "K_ECDH_ANON", "Lsun/security/ssl/CipherSuite$KeyExchange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "K_SCSV", "Lsun/security/ssl/CipherSuite$KeyExchange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allowed", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "groupTypes", "[Lsun/security/ssl/NamedGroup$NamedGroupSpec;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "alwaysAvailable", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isAnonymous", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/security/ssl/CipherSuite$KeyExchange;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;ZZ[Lsun/security/ssl/NamedGroup$NamedGroupSpec;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/security/ssl/CipherSuite$KeyExchange;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/ssl/CipherSuite$KeyExchange;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/security/ssl/CipherSuite$KeyExchange;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAvailable", "()Z"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$KeyExchange;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange K_NULL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$KeyExchange;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange K_RSA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$KeyExchange;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange K_RSA_EXPORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$KeyExchange;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange K_DH_RSA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$KeyExchange;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange K_DH_DSS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$KeyExchange;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange K_DHE_DSS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$KeyExchange;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange K_DHE_DSS_EXPORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$KeyExchange;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange K_DHE_RSA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$KeyExchange;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange K_DHE_RSA_EXPORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$KeyExchange;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange K_DH_ANON_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$KeyExchange;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange K_DH_ANON_EXPORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$KeyExchange;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange K_ECDH_ECDSA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$KeyExchange;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange K_ECDH_RSA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$KeyExchange;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange K_ECDHE_ECDSA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$KeyExchange;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange K_ECDHE_RSA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$KeyExchange;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange K_ECDH_ANON_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$KeyExchange;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange K_SCSV_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "final")]
		public bool allowed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[18]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[18], value);
			}
		}

		[JniSignatureAttribute("[Lsun/security/ssl/NamedGroup$NamedGroupSpec;", "final")]
		public JavaArray<Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec> groupTypes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool alwaysAvailable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[20]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[20], value);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool isAnonymous_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[21]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[21], value);
			}
		}

		[JniSignatureAttribute("[Lsun/security/ssl/CipherSuite$KeyExchange;", "private static final")]
		public static JavaArray<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public KeyExchange(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;ZZ[Lsun/security/ssl/NamedGroup$NamedGroupSpec;)V", "private transient")]
		public KeyExchange(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, bool arg3, bool arg4, JavaArray<Dova.JDK.sun.security.ssl.NamedGroup.NamedGroupSpec> arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/CipherSuite$KeyExchange;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()[Lsun/security/ssl/CipherSuite$KeyExchange;", "public static")]
		public static JavaArray<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/ssl/CipherSuite$KeyExchange;", "public static")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>(ret);
		}

		[JniSignatureAttribute("()[Lsun/security/ssl/CipherSuite$KeyExchange;", "private static")]
		public static JavaArray<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange>>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isAvailable()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$MacAlg;", "static final")]
	public partial class MacAlg
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MacAlg()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/CipherSuite$MacAlg;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "M_NULL", "Lsun/security/ssl/CipherSuite$MacAlg;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "M_MD5", "Lsun/security/ssl/CipherSuite$MacAlg;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "M_SHA", "Lsun/security/ssl/CipherSuite$MacAlg;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "M_SHA256", "Lsun/security/ssl/CipherSuite$MacAlg;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "M_SHA384", "Lsun/security/ssl/CipherSuite$MacAlg;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "size", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashBlockSize", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minimalPaddingSize", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/security/ssl/CipherSuite$MacAlg;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;III)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/security/ssl/CipherSuite$MacAlg;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/ssl/CipherSuite$MacAlg;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/security/ssl/CipherSuite$MacAlg;"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$MacAlg;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.MacAlg M_NULL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.MacAlg>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$MacAlg;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.MacAlg M_MD5_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.MacAlg>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$MacAlg;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.MacAlg M_SHA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.MacAlg>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$MacAlg;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.MacAlg M_SHA256_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.MacAlg>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$MacAlg;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.MacAlg M_SHA384_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.MacAlg>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "final")]
		public int size_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("I", "final")]
		public int hashBlockSize_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("I", "final")]
		public int minimalPaddingSize_Property
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

		[JniSignatureAttribute("[Lsun/security/ssl/CipherSuite$MacAlg;", "private static final")]
		public static JavaArray<Dova.JDK.sun.security.ssl.CipherSuite.MacAlg> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.CipherSuite.MacAlg>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MacAlg(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;III)V", "private")]
		public MacAlg(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, int arg3, int arg4, int arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/CipherSuite$MacAlg;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()[Lsun/security/ssl/CipherSuite$MacAlg;", "public static")]
		public static JavaArray<Dova.JDK.sun.security.ssl.CipherSuite.MacAlg> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.CipherSuite.MacAlg>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/ssl/CipherSuite$MacAlg;", "public static")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.MacAlg valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.MacAlg>(ret);
		}

		[JniSignatureAttribute("()[Lsun/security/ssl/CipherSuite$MacAlg;", "private static")]
		public static JavaArray<Dova.JDK.sun.security.ssl.CipherSuite.MacAlg> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.CipherSuite.MacAlg>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$HashAlg;", "static final")]
	public partial class HashAlg
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HashAlg()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/CipherSuite$HashAlg;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "H_NONE", "Lsun/security/ssl/CipherSuite$HashAlg;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "H_SHA256", "Lsun/security/ssl/CipherSuite$HashAlg;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "H_SHA384", "Lsun/security/ssl/CipherSuite$HashAlg;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashLength", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "blockSize", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/security/ssl/CipherSuite$HashAlg;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/security/ssl/CipherSuite$HashAlg;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/ssl/CipherSuite$HashAlg;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/security/ssl/CipherSuite$HashAlg;"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$HashAlg;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.HashAlg H_NONE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.HashAlg>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$HashAlg;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.HashAlg H_SHA256_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.HashAlg>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$HashAlg;", "public static final")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.HashAlg H_SHA384_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.HashAlg>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "final")]
		public int hashLength_Property
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

		[JniSignatureAttribute("I", "final")]
		public int blockSize_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("[Lsun/security/ssl/CipherSuite$HashAlg;", "private static final")]
		public static JavaArray<Dova.JDK.sun.security.ssl.CipherSuite.HashAlg> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.CipherSuite.HashAlg>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HashAlg(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;II)V", "private")]
		public HashAlg(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, int arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/CipherSuite$HashAlg;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()[Lsun/security/ssl/CipherSuite$HashAlg;", "public static")]
		public static JavaArray<Dova.JDK.sun.security.ssl.CipherSuite.HashAlg> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.CipherSuite.HashAlg>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/ssl/CipherSuite$HashAlg;", "public static")]
		public static Dova.JDK.sun.security.ssl.CipherSuite.HashAlg valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.HashAlg>(ret);
		}

		[JniSignatureAttribute("()[Lsun/security/ssl/CipherSuite$HashAlg;", "private static")]
		public static JavaArray<Dova.JDK.sun.security.ssl.CipherSuite.HashAlg> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.CipherSuite.HashAlg>>(ret);
		}
	}
}
