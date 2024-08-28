using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace NVP_Renga_COM._Renga.ObjectWithLayeredMaterial 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ObjectWithLayeredMaterial_Constructor : INode 
	{
		public Renga.IObjectWithLayeredMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IObjectWithLayeredMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ObjectWithLayeredMaterial_ConstructorCast : INode 
	{
		public Renga.IObjectWithLayeredMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IObjectWithLayeredMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("ObjectWithLayeredMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetLayeredMaterialIdGroupPair : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLayeredMaterialIdGroupPair);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("ObjectWithLayeredMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class HasLayeredMaterial : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasLayeredMaterial);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("ObjectWithLayeredMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetLayers : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLayers);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("ObjectWithLayeredMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LayeredMaterialId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayeredMaterialId);

		}
	}
}
