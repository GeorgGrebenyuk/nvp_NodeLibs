using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Interface for a face on an AcDb3dSolid
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadSubEntSolidFace 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSubEntSolidFace_Constructor : INode 
	{
		public OdaX.IAcadSubEntSolidFace _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSubEntSolidFace;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSubEntSolidFace_ConstructorCast : INode 
	{
		public OdaX.IAcadSubEntSolidFace _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSubEntSolidFace;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies the material", 
		ViewType = "Data")]
	[NodeInput("AcadSubEntSolidFace", typeof(object))]

	///<summary>
	///Specifies the material
	///</summary>
	public class Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Material);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the material", 
		ViewType = "Modifier")]
	[NodeInput("AcadSubEntSolidFace", typeof(object))]
	[NodeInput("Material", typeof(System.String))]

	///<summary>
	///Specifies the material
	///</summary>
	public class Set_Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Material = inputs[1].Value;
			return null;
		}
	}
}
