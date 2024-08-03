using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcCellContentType 
{


	[NVP_Manifest(
		Id = "D86FDD4C-3A99-4D44-98AC-46F2452C99C0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellContentType.enum_acCellContentTypeUnknown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellContentType", 
		NodeName = "enum_acCellContentTypeUnknown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellContentTypeUnknown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellContentType.acCellContentTypeUnknown);

		}
	}


	[NVP_Manifest(
		Id = "973ECD1F-CC83-4870-A6C4-B8274B7F0CB9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellContentType.enum_acCellContentTypeValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellContentType", 
		NodeName = "enum_acCellContentTypeValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellContentTypeValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellContentType.acCellContentTypeValue);

		}
	}


	[NVP_Manifest(
		Id = "F7CF2363-B34C-4482-AA13-BEB0EFE863F3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellContentType.enum_acCellContentTypeField", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellContentType", 
		NodeName = "enum_acCellContentTypeField", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellContentTypeField : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellContentType.acCellContentTypeField);

		}
	}


	[NVP_Manifest(
		Id = "8AD1A61C-DAF9-40FC-9EE9-FD410EDFFBF9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellContentType.enum_acCellContentTypeBlock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellContentType", 
		NodeName = "enum_acCellContentTypeBlock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellContentTypeBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellContentType.acCellContentTypeBlock);

		}
	}
}
