using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_AcMenuFileType 
{


	[NVP_Manifest(
		Id = "AF9BA96D-BCB2-41F5-8016-FFC336397681", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcMenuFileType.enum_acMenuFileCompiled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcMenuFileType", 
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
			return new NodeResult(nanoCAD.AcMenuFileType.acMenuFileCompiled);

		}
	}


	[NVP_Manifest(
		Id = "2BC6AFA6-3DDE-43CF-B346-34D17EF23F91", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcMenuFileType.enum_acMenuFileSource", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcMenuFileType", 
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
			return new NodeResult(nanoCAD.AcMenuFileType.acMenuFileSource);

		}
	}
}
