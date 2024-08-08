using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrReinfPlane Interface
///</summary>
namespace ironObjComLib.WrReinfPlane 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrReinfPlane_Constructor : INode 
	{
		public ironObjComLib.IWrReinfPlane _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrReinfPlane;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrReinfPlane_ConstructorCast : INode 
	{
		public ironObjComLib.IWrReinfPlane _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrReinfPlane;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("WrReinfPlane", typeof(object))]

	///<summary>
	///Параметры
	///</summary>
	public class Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Element);

		}
	}


	[NVP_Manifest(
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfPlane", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Параметры
	///</summary>
	public class Set_Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Element = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property ConcCover", 
		ViewType = "Data")]
	[NodeInput("WrReinfPlane", typeof(object))]

	///<summary>
	///property ConcCover
	///</summary>
	public class ConcCover : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConcCover);

		}
	}


	[NVP_Manifest(
		Text = "property ConcCover", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfPlane", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ConcCover
	///</summary>
	public class Set_ConcCover : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ConcCover = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property AddOffset", 
		ViewType = "Data")]
	[NodeInput("WrReinfPlane", typeof(object))]

	///<summary>
	///property AddOffset
	///</summary>
	public class AddOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddOffset);

		}
	}


	[NVP_Manifest(
		Text = "property AddOffset", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfPlane", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property AddOffset
	///</summary>
	public class Set_AddOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddOffset = inputs[1].Value;
			return null;
		}
	}
}
