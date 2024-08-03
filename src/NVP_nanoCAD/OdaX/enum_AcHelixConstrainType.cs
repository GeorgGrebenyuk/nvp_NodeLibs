using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcHelixConstrainType 
{


	[NVP_Manifest(
		Id = "C889F59D-1F46-4B48-85C5-80ADB4992365", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcHelixConstrainType.enum_acTurnHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcHelixConstrainType", 
		NodeName = "enum_acTurnHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTurnHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcHelixConstrainType.acTurnHeight);

		}
	}


	[NVP_Manifest(
		Id = "A17A9B35-5D1E-4EF2-AEB4-B1F13FDBE0D3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcHelixConstrainType.enum_acTurns", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcHelixConstrainType", 
		NodeName = "enum_acTurns", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTurns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcHelixConstrainType.acTurns);

		}
	}


	[NVP_Manifest(
		Id = "DE74CEB4-7213-47F5-9433-5493BDE28A99", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcHelixConstrainType.enum_acHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcHelixConstrainType", 
		NodeName = "enum_acHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcHelixConstrainType.acHeight);

		}
	}
}
