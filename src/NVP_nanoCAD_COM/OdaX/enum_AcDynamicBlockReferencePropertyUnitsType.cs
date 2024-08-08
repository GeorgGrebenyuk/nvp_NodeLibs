using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcDynamicBlockReferencePropertyUnitsType 
{


	[NVP_Manifest(
		Id = "192C4005-1C8D-471C-9F63-584FF16FD79F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDynamicBlockReferencePropertyUnitsType.enum_acNoUnits", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDynamicBlockReferencePropertyUnitsType", 
		NodeName = "enum_acNoUnits", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acNoUnits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDynamicBlockReferencePropertyUnitsType.acNoUnits);

		}
	}


	[NVP_Manifest(
		Id = "8331B2D1-7F3E-450E-8B4D-D14E45CA3A89", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDynamicBlockReferencePropertyUnitsType.enum_acAngular", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDynamicBlockReferencePropertyUnitsType", 
		NodeName = "enum_acAngular", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAngular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDynamicBlockReferencePropertyUnitsType.acAngular);

		}
	}


	[NVP_Manifest(
		Id = "00EC2E71-B89C-4420-AE93-3342323009C2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDynamicBlockReferencePropertyUnitsType.enum_acDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDynamicBlockReferencePropertyUnitsType", 
		NodeName = "enum_acDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDynamicBlockReferencePropertyUnitsType.acDistance);

		}
	}


	[NVP_Manifest(
		Id = "C9F57932-A34F-49D5-AEBB-E1F7BBD80CE9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDynamicBlockReferencePropertyUnitsType.enum_acArea", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDynamicBlockReferencePropertyUnitsType", 
		NodeName = "enum_acArea", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArea : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDynamicBlockReferencePropertyUnitsType.acArea);

		}
	}
}
