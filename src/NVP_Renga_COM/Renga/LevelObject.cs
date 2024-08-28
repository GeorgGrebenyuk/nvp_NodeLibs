using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace NVP_Renga_COM._Renga.LevelObject 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LevelObject_Constructor : INode 
	{
		public Renga.ILevelObject _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ILevelObject;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LevelObject_ConstructorCast : INode 
	{
		public Renga.ILevelObject _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ILevelObject;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("LevelObject", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LevelId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LevelId);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("LevelObject", typeof(object))]

	///<summary>
	///
	///</summary>
	public class VerticalOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VerticalOffset);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("LevelObject", typeof(object))]

	///<summary>
	///
	///</summary>
	public class PlacementElevation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlacementElevation);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("LevelObject", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ElevationAboveLevel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ElevationAboveLevel);

		}
	}
}
