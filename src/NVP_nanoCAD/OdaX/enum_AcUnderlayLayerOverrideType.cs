using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcUnderlayLayerOverrideType 
{


	[NVP_Manifest(
		Id = "C6D8D309-5470-4100-A49A-7DEA97D558D6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcUnderlayLayerOverrideType.enum_acNoOverrides", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcUnderlayLayerOverrideType", 
		NodeName = "enum_acNoOverrides", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acNoOverrides : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcUnderlayLayerOverrideType.acNoOverrides);

		}
	}


	[NVP_Manifest(
		Id = "6C068F7C-BC1E-40EF-93AD-504EB2B24E51", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcUnderlayLayerOverrideType.enum_acApplied", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcUnderlayLayerOverrideType", 
		NodeName = "enum_acApplied", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acApplied : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcUnderlayLayerOverrideType.acApplied);

		}
	}
}
