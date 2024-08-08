using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.LayeredMaterialManager 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LayeredMaterialManager_Constructor : INode 
	{
		public Renga.ILayeredMaterialManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ILayeredMaterialManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LayeredMaterialManager_ConstructorCast : INode 
	{
		public Renga.ILayeredMaterialManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ILayeredMaterialManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("LayeredMaterialManager", typeof(object))]
	[NodeInput("LayeredMaterialIdGroupPair", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetLayeredMaterialByIdGroupPair : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLayeredMaterialByIdGroupPair(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("LayeredMaterialManager", typeof(object))]
	[NodeInput("Id", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetLayeredMaterial : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLayeredMaterial(inputs[1].Value));

		}
	}
}
