using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Interface for a vertex on an AcDb3dSolid
///</summary>
namespace OdaX.AcadSubEntSolidVertex 
{

	[NVP_Manifest(
		Id = "D89001BE-15E5-4FDB-AABB-2674586F4684", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSubEntSolidVertex.AcadSubEntSolidVertex_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSubEntSolidVertex", 
		NodeName = "_AcadSubEntSolidVertex_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSubEntSolidVertex_Constructor : INode 
	{
		public OdaX.IAcadSubEntSolidVertex _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSubEntSolidVertex;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "ED02DDA8-4AA1-41C7-8D8F-4B6B66E22A37", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSubEntSolidVertex.AcadSubEntSolidVertex_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSubEntSolidVertex", 
		NodeName = "_AcadSubEntSolidVertex_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSubEntSolidVertex_ConstructorCast : INode 
	{
		public OdaX.IAcadSubEntSolidVertex _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSubEntSolidVertex;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
