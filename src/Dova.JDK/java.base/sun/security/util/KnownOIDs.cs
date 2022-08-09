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

namespace Dova.JDK.sun.security.util;

[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public")]
public partial class KnownOIDs
	: Dova.JDK.java.lang.Enum
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KnownOIDs()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/util/KnownOIDs;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CommonName", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "Surname", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SerialNumber", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CountryName", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LocalityName", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "StateName", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "StreetAddress", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OrgName", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OrgUnitName", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "Title", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GivenName", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "Initials", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "GenerationQualifier", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DNQualifier", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SubjectDirectoryAttributes", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SubjectKeyID", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KeyUsage", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PrivateKeyUsage", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SubjectAlternativeName", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "IssuerAlternativeName", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "BasicConstraints", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CRLNumber", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ReasonCode", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HoldInstructionCode", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "InvalidityDate", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DeltaCRLIndicator", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "IssuingDistributionPoint", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CertificateIssuer", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NameConstraints", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CRLDistributionPoints", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CertificatePolicies", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CE_CERT_POLICIES_ANY", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PolicyMappings", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AuthorityKeyID", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PolicyConstraints", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "extendedKeyUsage", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "anyExtendedKeyUsage", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "FreshestCRL", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "InhibitAnyPolicy", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AuthInfoAccess", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SubjectInfoAccess", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serverAuth", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "clientAuth", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "codeSigning", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "emailProtection", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ipsecEndSystem", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ipsecTunnel", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ipsecUser", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "KP_TimeStamping", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OCSPSigning", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OCSP", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OCSPBasicResponse", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OCSPNonceExt", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OCSPNoCheck", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "caIssuers", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AD_TimeStamping", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "caRepository", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES_128$ECB$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES_128$CBC$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES_128$OFB$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES_128$CFB$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES_128$KW$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES_128$GCM$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES_128$KWP$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES_192$ECB$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES_192$CBC$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES_192$OFB$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES_192$CFB$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES_192$KW$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES_192$GCM$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES_192$KWP$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES_256$ECB$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES_256$CBC$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES_256$OFB$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES_256$CFB$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES_256$KW$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES_256$GCM$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "AES_256$KWP$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA_256", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA_384", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA_512", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA_224", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA_512$224", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA_512$256", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA3_224", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA3_256", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA3_384", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA3_512", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHAKE128", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHAKE256", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HmacSHA3_224", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HmacSHA3_256", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HmacSHA3_384", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HmacSHA3_512", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHAKE128_LEN", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHAKE256_LEN", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA224withDSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA256withDSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA384withDSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA512withDSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA3_224withDSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA3_256withDSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA3_384withDSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA3_512withDSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA3_224withECDSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA3_256withECDSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA3_384withECDSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA3_512withECDSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA3_224withRSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA3_256withRSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA3_384withRSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA3_512withRSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PKCS1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "RSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MD2withRSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MD5withRSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA1withRSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OAEP", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MGF1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PSpecified", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "RSASSA_PSS", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA256withRSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA384withRSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA512withRSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA224withRSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA512$224withRSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA512$256withRSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DiffieHellman", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PBEWithMD5AndDES", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PBEWithMD5AndRC2", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PBEWithSHA1AndDES", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PBEWithSHA1AndRC2", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PBKDF2WithHmacSHA1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PBES2", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PKCS7", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "Data", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SignedData", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JDK_OLD_Data", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JDK_OLD_SignedData", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "EnvelopedData", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SignedAndEnvelopedData", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DigestedData", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "EncryptedData", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "EmailAddress", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "UnstructuredName", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ContentType", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MessageDigest", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SigningTime", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CounterSignature", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ChallengePassword", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "UnstructuredAddress", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ExtendedCertificateAttributes", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "IssuerAndSerialNumber", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ExtensionRequest", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SMIMECapability", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TimeStampTokenInfo", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SigningCertificate", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SignatureTimestampToken", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CHACHA20_POLY1305", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "FriendlyName", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LocalKeyID", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CertTypeX509", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CMSAlgorithmProtection", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PBEWithSHA1AndRC4_128", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PBEWithSHA1AndRC4_40", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PBEWithSHA1AndDESede", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PBEWithSHA1AndRC2_128", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PBEWithSHA1AndRC2_40", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PKCS8ShroudedKeyBag", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CertBag", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SecretBag", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MD2", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MD5", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HmacSHA1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HmacSHA224", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HmacSHA256", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HmacSHA384", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HmacSHA512", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HmacSHA512$224", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HmacSHA512$256", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "RC2$CBC$PKCS5Padding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ARCFOUR", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DESede$CBC$NoPadding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "RC5$CBC$PKCS5Padding", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA1withDSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "EC", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "c2tnb191v1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "c2tnb191v2", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "c2tnb191v3", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "c2tnb239v1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "c2tnb239v2", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "c2tnb239v3", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "c2tnb359v1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "c2tnb431r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "secp192r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "prime192v2", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "prime192v3", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "prime239v1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "prime239v2", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "prime239v3", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "secp256r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA1withECDSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA224withECDSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA256withECDSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA384withECDSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA512withECDSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SpecifiedSHA2withECDSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "X942_DH", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "brainpoolP160r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "brainpoolP192r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "brainpoolP224r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "brainpoolP256r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "brainpoolP320r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "brainpoolP384r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "brainpoolP512r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "sect163k1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "sect163r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "sect239k1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "sect113r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "sect113r2", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "secp112r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "secp112r2", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "secp160r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "secp160k1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "secp256k1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "sect163r2", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "sect283k1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "sect283r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "sect131r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "sect131r2", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "sect193r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "sect193r2", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "sect233k1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "sect233r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "secp128r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "secp128r2", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "secp160r2", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "secp192k1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "secp224k1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "secp224r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "secp384r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "secp521r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "sect409k1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "sect409r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "sect571k1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "sect571r1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ECDH", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OIW_DES_CBC", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OIW_DSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OIW_JDK_SHA1withDSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OIW_SHA1withRSA_Odd", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DESede", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SHA_1", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OIW_SHA1withDSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OIW_SHA1withRSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "X25519", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "X448", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "Ed25519", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "Ed448", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "UCL_UserID", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "UCL_DomainComponent", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NETSCAPE_CertType", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NETSCAPE_CertSequence", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NETSCAPE_ExportApproved", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ORACLE_TrustedKeyUsage", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ITUX509_RSA", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SkipIPAddress", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JAVASOFT_JDKKeyProtector", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JAVASOFT_JCEKeyProtector", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MICROSOFT_ExportApproved", "Lsun/security/util/KnownOIDs;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "stdName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "oid", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "aliases", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "debug", "Lsun/security/util/Debug;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "name2enum", "Ljava/util/concurrent/ConcurrentHashMap;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lsun/security/util/KnownOIDs;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "KnownOIDs", "(Ljava/lang/String;ILjava/lang/String;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "KnownOIDs", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "value", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lsun/security/util/KnownOIDs;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/util/KnownOIDs;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "register", "(Lsun/security/util/KnownOIDs;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "aliases", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lsun/security/util/KnownOIDs;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "registerNames", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "findMatch", "(Ljava/lang/String;)Lsun/security/util/KnownOIDs;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "stdName", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs CommonName_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs Surname_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SerialNumber_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs CountryName_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs LocalityName_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs StateName_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs StreetAddress_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs OrgName_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs OrgUnitName_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs Title_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs GivenName_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs Initials_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs GenerationQualifier_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs DNQualifier_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SubjectDirectoryAttributes_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SubjectKeyID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs KeyUsage_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs PrivateKeyUsage_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SubjectAlternativeName_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs IssuerAlternativeName_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs BasicConstraints_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs CRLNumber_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs ReasonCode_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs HoldInstructionCode_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs InvalidityDate_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs DeltaCRLIndicator_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs IssuingDistributionPoint_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs CertificateIssuer_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs NameConstraints_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs CRLDistributionPoints_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs CertificatePolicies_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs CE_CERT_POLICIES_ANY_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs PolicyMappings_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AuthorityKeyID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs PolicyConstraints_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs extendedKeyUsage_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs anyExtendedKeyUsage_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs FreshestCRL_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs InhibitAnyPolicy_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AuthInfoAccess_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SubjectInfoAccess_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs serverAuth_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs clientAuth_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs codeSigning_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs emailProtection_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs ipsecEndSystem_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs ipsecTunnel_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs ipsecUser_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs KP_TimeStamping_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs OCSPSigning_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs OCSP_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs OCSPBasicResponse_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs OCSPNonceExt_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs OCSPNoCheck_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs caIssuers_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AD_TimeStamping_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[55]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[55], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs caRepository_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[56]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[56], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_128ECBNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_128CBCNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_128OFBNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_128CFBNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[61]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[61], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_128KWNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[62]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[62], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_128GCMNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[63]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[63], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_128KWPNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_192ECBNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_192CBCNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_192OFBNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_192CFBNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[68]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[68], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_192KWNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[69]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[69], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_192GCMNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_192KWPNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[71]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[71], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_256ECBNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[72]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[72], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_256CBCNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[73]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[73], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_256OFBNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[74]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[74], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_256CFBNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[75]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[75], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_256KWNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[76]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[76], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_256GCMNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[77]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[77], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs AES_256KWPNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[78]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[78], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA_256_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[79]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[79], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA_384_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[80]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[80], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA_512_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[81]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[81], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA_224_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[82]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[82], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA_512224_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[83]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[83], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA_512256_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[84]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[84], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA3_224_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[85]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[85], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA3_256_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[86]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[86], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA3_384_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[87]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[87], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA3_512_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[88]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[88], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHAKE128_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[89]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[89], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHAKE256_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[90]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[90], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs HmacSHA3_224_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[91]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[91], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs HmacSHA3_256_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[92]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[92], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs HmacSHA3_384_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[93]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[93], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs HmacSHA3_512_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[94]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[94], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHAKE128_LEN_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[95]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[95], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHAKE256_LEN_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[96]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[96], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA224withDSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[97]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[97], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA256withDSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[98]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[98], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA384withDSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[99]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[99], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA512withDSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[100]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[100], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA3_224withDSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[101]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[101], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA3_256withDSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[102]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[102], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA3_384withDSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[103]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[103], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA3_512withDSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[104]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[104], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA3_224withECDSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[105]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[105], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA3_256withECDSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[106]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[106], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA3_384withECDSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[107]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[107], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA3_512withECDSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[108]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[108], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA3_224withRSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[109]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[109], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA3_256withRSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[110]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[110], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA3_384withRSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[111]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[111], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA3_512withRSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[112]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[112], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs PKCS1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[113]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[113], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs RSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[114]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[114], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs MD2withRSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[115]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[115], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs MD5withRSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[116]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[116], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA1withRSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[117]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[117], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs OAEP_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[118]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[118], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs MGF1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[119]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[119], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs PSpecified_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[120]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[120], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs RSASSA_PSS_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[121]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[121], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA256withRSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[122]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[122], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA384withRSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[123]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[123], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA512withRSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[124]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[124], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA224withRSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[125]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[125], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA512224withRSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[126]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[126], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA512256withRSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[127]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[127], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs DiffieHellman_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[128]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[128], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs PBEWithMD5AndDES_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[129]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[129], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs PBEWithMD5AndRC2_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[130]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[130], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs PBEWithSHA1AndDES_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[131]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[131], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs PBEWithSHA1AndRC2_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[132]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[132], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs PBKDF2WithHmacSHA1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[133]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[133], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs PBES2_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[134]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[134], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs PKCS7_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[135]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[135], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs Data_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[136]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[136], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SignedData_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[137]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[137], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs JDK_OLD_Data_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[138]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[138], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs JDK_OLD_SignedData_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[139]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[139], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs EnvelopedData_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[140]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[140], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SignedAndEnvelopedData_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[141]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[141], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs DigestedData_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[142]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[142], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs EncryptedData_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[143]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[143], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs EmailAddress_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[144]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[144], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs UnstructuredName_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[145]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[145], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs ContentType_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[146]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[146], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs MessageDigest_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[147]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[147], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SigningTime_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[148]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[148], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs CounterSignature_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[149]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[149], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs ChallengePassword_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[150]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[150], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs UnstructuredAddress_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[151]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[151], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs ExtendedCertificateAttributes_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[152]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[152], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs IssuerAndSerialNumber_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[153]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[153], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs ExtensionRequest_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[154]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[154], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SMIMECapability_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[155]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[155], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs TimeStampTokenInfo_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[156]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[156], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SigningCertificate_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[157]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[157], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SignatureTimestampToken_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[158]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[158], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs CHACHA20_POLY1305_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[159]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[159], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs FriendlyName_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[160]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[160], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs LocalKeyID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[161]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[161], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs CertTypeX509_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[162]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[162], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs CMSAlgorithmProtection_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[163]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[163], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs PBEWithSHA1AndRC4_128_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[164]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[164], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs PBEWithSHA1AndRC4_40_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[165]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[165], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs PBEWithSHA1AndDESede_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[166]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[166], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs PBEWithSHA1AndRC2_128_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[167]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[167], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs PBEWithSHA1AndRC2_40_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[168]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[168], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs PKCS8ShroudedKeyBag_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[169]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[169], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs CertBag_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[170]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[170], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SecretBag_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[171]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[171], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs MD2_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[172]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[172], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs MD5_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[173]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[173], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs HmacSHA1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[174]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[174], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs HmacSHA224_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[175]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[175], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs HmacSHA256_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[176]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[176], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs HmacSHA384_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[177]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[177], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs HmacSHA512_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[178]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[178], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs HmacSHA512224_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[179]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[179], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs HmacSHA512256_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[180]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[180], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs RC2CBCPKCS5Padding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[181]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[181], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs ARCFOUR_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[182]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[182], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs DESedeCBCNoPadding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[183]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[183], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs RC5CBCPKCS5Padding_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[184]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[184], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs DSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[185]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[185], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA1withDSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[186]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[186], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs EC_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[187]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[187], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs c2tnb191v1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[188]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[188], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs c2tnb191v2_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[189]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[189], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs c2tnb191v3_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[190]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[190], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs c2tnb239v1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[191]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[191], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs c2tnb239v2_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[192]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[192], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs c2tnb239v3_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[193]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[193], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs c2tnb359v1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[194]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[194], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs c2tnb431r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[195]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[195], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs secp192r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[196]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[196], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs prime192v2_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[197]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[197], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs prime192v3_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[198]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[198], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs prime239v1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[199]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[199], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs prime239v2_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[200]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[200], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs prime239v3_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[201]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[201], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs secp256r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[202]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[202], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA1withECDSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[203]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[203], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA224withECDSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[204]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[204], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA256withECDSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[205]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[205], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA384withECDSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[206]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[206], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA512withECDSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[207]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[207], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SpecifiedSHA2withECDSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[208]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[208], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs X942_DH_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[209]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[209], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs brainpoolP160r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[210]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[210], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs brainpoolP192r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[211]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[211], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs brainpoolP224r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[212]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[212], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs brainpoolP256r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[213]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[213], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs brainpoolP320r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[214]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[214], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs brainpoolP384r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[215]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[215], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs brainpoolP512r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[216]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[216], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs sect163k1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[217]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[217], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs sect163r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[218]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[218], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs sect239k1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[219]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[219], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs sect113r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[220]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[220], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs sect113r2_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[221]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[221], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs secp112r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[222]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[222], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs secp112r2_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[223]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[223], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs secp160r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[224]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[224], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs secp160k1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[225]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[225], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs secp256k1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[226]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[226], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs sect163r2_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[227]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[227], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs sect283k1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[228]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[228], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs sect283r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[229]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[229], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs sect131r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[230]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[230], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs sect131r2_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[231]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[231], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs sect193r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[232]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[232], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs sect193r2_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[233]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[233], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs sect233k1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[234]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[234], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs sect233r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[235]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[235], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs secp128r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[236]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[236], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs secp128r2_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[237]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[237], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs secp160r2_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[238]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[238], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs secp192k1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[239]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[239], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs secp224k1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[240]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[240], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs secp224r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[241]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[241], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs secp384r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[242]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[242], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs secp521r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[243]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[243], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs sect409k1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[244]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[244], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs sect409r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[245]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[245], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs sect571k1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[246]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[246], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs sect571r1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[247]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[247], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs ECDH_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[248]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[248], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs OIW_DES_CBC_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[249]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[249], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs OIW_DSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[250]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[250], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs OIW_JDK_SHA1withDSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[251]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[251], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs OIW_SHA1withRSA_Odd_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[252]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[252], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs DESede_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[253]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[253], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SHA_1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[254]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[254], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs OIW_SHA1withDSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[255]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[255], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs OIW_SHA1withRSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[256]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[256], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs X25519_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[257]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[257], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs X448_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[258]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[258], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs Ed25519_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[259]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[259], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs Ed448_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[260]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[260], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs UCL_UserID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[261]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[261], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs UCL_DomainComponent_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[262]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[262], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs NETSCAPE_CertType_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[263]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[263], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs NETSCAPE_CertSequence_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[264]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[264], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs NETSCAPE_ExportApproved_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[265]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[265], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs ORACLE_TrustedKeyUsage_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[266]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[266], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs ITUX509_RSA_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[267]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[267], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs SkipIPAddress_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[268]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[268], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs JAVASOFT_JDKKeyProtector_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[269]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[269], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs JAVASOFT_JCEKeyProtector_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[270]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[270], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/KnownOIDs;", "public static final")]
	public static Dova.JDK.sun.security.util.KnownOIDs MICROSOFT_ExportApproved_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[271]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[271], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String stdName_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[272]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[272], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String oid_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[273]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[273], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private")]
	public JavaArray<Dova.JDK.java.lang.String> aliases_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[274]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[274], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/Debug;", "private static final")]
	public static Dova.JDK.sun.security.util.Debug debug_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[275]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.Debug>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[275], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentHashMap;", "private static final")]
	public static Dova.JDK.java.util.concurrent.ConcurrentHashMap name2enum_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[276]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentHashMap>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[276], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Lsun/security/util/KnownOIDs;", "private static final")]
	public static JavaArray<Dova.JDK.sun.security.util.KnownOIDs> VALUES_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[277]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.util.KnownOIDs>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[277], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public KnownOIDs(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
	public KnownOIDs(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V", "private transient")]
	public KnownOIDs(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, JavaArray<Dova.JDK.java.lang.String> arg4) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/util/KnownOIDs;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String value()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()[Lsun/security/util/KnownOIDs;", "public static")]
	public static JavaArray<Dova.JDK.sun.security.util.KnownOIDs> values()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.util.KnownOIDs>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/util/KnownOIDs;", "public static")]
	public static Dova.JDK.sun.security.util.KnownOIDs valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/util/KnownOIDs;)V", "private static")]
	public static void register(Dova.JDK.sun.security.util.KnownOIDs arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> aliases()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()[Lsun/security/util/KnownOIDs;", "private static")]
	public static JavaArray<Dova.JDK.sun.security.util.KnownOIDs> _values()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.util.KnownOIDs>>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool registerNames()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/util/KnownOIDs;", "public static")]
	public static Dova.JDK.sun.security.util.KnownOIDs findMatch(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.KnownOIDs>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String stdName()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
