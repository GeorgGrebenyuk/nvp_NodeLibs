using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcMenuFileType 
{


	[NVP_Manifest(
		Id = "BC29CCA1-1FF9-45D8-AFD1-D62D3948E1E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcMenuFileType.enum_acMenuFileCompiled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcMenuFileType", 
		NodeName = "enum_acMenuFileCompiled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acMenuFileCompiled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcMenuFileType.acMenuFileCompiled);

		}
	}


	[NVP_Manifest(
		Id = "DEECB903-7245-4DEC-8667-16A4A87D4484", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcMenuFileType.enum_acMenuFileSource", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcMenuFileType", 
		NodeName = "enum_acMenuFileSource", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acMenuFileSource : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcMenuFileType.acMenuFileSource);

		}
	}
}
