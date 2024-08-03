using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcMLeaderType 
{


	[NVP_Manifest(
		Id = "A4C78D52-C1B5-493E-A3D6-4723A0851E2F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcMLeaderType.enum_acStraightLeader", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcMLeaderType", 
		NodeName = "enum_acStraightLeader", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acStraightLeader : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcMLeaderType.acStraightLeader);

		}
	}


	[NVP_Manifest(
		Id = "2D13D96C-2B16-4C0A-A896-B5CC37D9FD6D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcMLeaderType.enum_acSplineLeader", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcMLeaderType", 
		NodeName = "enum_acSplineLeader", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSplineLeader : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcMLeaderType.acSplineLeader);

		}
	}


	[NVP_Manifest(
		Id = "9453192C-FB8C-418B-BDA3-EFEC84616332", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcMLeaderType.enum_acInVisibleLeader", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcMLeaderType", 
		NodeName = "enum_acInVisibleLeader", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInVisibleLeader : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcMLeaderType.acInVisibleLeader);

		}
	}
}
