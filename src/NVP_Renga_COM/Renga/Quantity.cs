using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace NVP_Renga_COM._Renga.Quantity 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Quantity_Constructor : INode 
	{
		public Renga.IQuantity _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IQuantity;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Quantity_ConstructorCast : INode 
	{
		public Renga.IQuantity _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IQuantity;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Quantity", typeof(object))]

	///<summary>
	///
	///</summary>
	public class HasValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasValue);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Quantity", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Quantity", typeof(object))]

	///<summary>
	///
	///</summary>
	public class AsCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AsCount);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Quantity", typeof(object))]
	[NodeInput("Renga.LengthUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AsLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AsLength(((Renga.LengthUnit)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Quantity", typeof(object))]
	[NodeInput("Renga.AreaUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AsArea : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AsArea(((Renga.AreaUnit)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Quantity", typeof(object))]
	[NodeInput("Renga.VolumeUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AsVolume : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AsVolume(((Renga.VolumeUnit)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Quantity", typeof(object))]
	[NodeInput("Renga.MassUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AsMass : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AsMass(((Renga.MassUnit)inputs[1].Value)));

		}
	}
}
