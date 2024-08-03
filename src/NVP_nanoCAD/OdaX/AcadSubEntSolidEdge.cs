using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Interface for a edge on an AcDb3dSolid
///</summary>
namespace OdaX.AcadSubEntSolidEdge 
{

	[NVP_Manifest(
		Id = "C8480810-2B67-48AB-8B54-4E8D7B912F90", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSubEntSolidEdge.AcadSubEntSolidEdge_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSubEntSolidEdge", 
		NodeName = "_AcadSubEntSolidEdge_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSubEntSolidEdge_Constructor : INode 
	{
		public OdaX.IAcadSubEntSolidEdge _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSubEntSolidEdge;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "0A2D86B1-B5D0-4A45-9B22-22EF159855C3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSubEntSolidEdge.AcadSubEntSolidEdge_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSubEntSolidEdge", 
		NodeName = "_AcadSubEntSolidEdge_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSubEntSolidEdge_ConstructorCast : INode 
	{
		public OdaX.IAcadSubEntSolidEdge _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSubEntSolidEdge;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
