using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.LayeredMaterial 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LayeredMaterial_Constructor : INode 
	{
		public Renga.ILayeredMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ILayeredMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LayeredMaterial_ConstructorCast : INode 
	{
		public Renga.ILayeredMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ILayeredMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("LayeredMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetIdGroupPair : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetIdGroupPair);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("LayeredMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("LayeredMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Layers : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Layers);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("LayeredMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetBaseLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBaseLayer);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("LayeredMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class BaseLayerIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BaseLayerIndex);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("LayeredMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}
}
