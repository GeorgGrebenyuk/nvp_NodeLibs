using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_IfcVersion 
{


	[NVP_Manifest(
		Id = "E18C1BF3-54B5-49FC-8D7D-30123DB0F358", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_IfcVersion.enum_IfcVersion_4", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_IfcVersion", 
		NodeName = "enum_IfcVersion_4", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_IfcVersion_4 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.IfcVersion.IfcVersion_4);

		}
	}
}
