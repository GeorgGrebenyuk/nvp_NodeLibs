using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcLineSpacingStyle 
{


	[NVP_Manifest(
		Id = "C536593C-CD0A-48B2-A7A5-9F4AE3A303FE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcLineSpacingStyle.enum_acLineSpacingStyleAtLeast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcLineSpacingStyle", 
		NodeName = "enum_acLineSpacingStyleAtLeast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acLineSpacingStyleAtLeast : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcLineSpacingStyle.acLineSpacingStyleAtLeast);

		}
	}


	[NVP_Manifest(
		Id = "C3364232-C459-4107-B851-4DBA61F04CE7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcLineSpacingStyle.enum_acLineSpacingStyleExactly", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcLineSpacingStyle", 
		NodeName = "enum_acLineSpacingStyleExactly", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acLineSpacingStyleExactly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcLineSpacingStyle.acLineSpacingStyleExactly);

		}
	}
}
