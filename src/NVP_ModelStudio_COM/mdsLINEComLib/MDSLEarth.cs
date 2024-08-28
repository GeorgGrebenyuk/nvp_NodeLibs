using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSLEarth Interface
///</summary>
namespace NVP_ModelStudio_COM._mdsLINEComLib.MDSLEarth 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLEarth_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLEarth _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLEarth;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLEarth_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLEarth _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLEarth;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("MDSLEarth", typeof(object))]

	///<summary>
	///property Element
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
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("MDSLEarth", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Element
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
		Text = "method GetHeight", 
		ViewType = "Data")]
	[NodeInput("MDSLEarth", typeof(object))]

	///<summary>
	///method GetHeight
	///</summary>
	public class GetElevation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetElevation);

		}
	}


	[NVP_Manifest(
		Text = "method GetPointCount", 
		ViewType = "Data")]
	[NodeInput("MDSLEarth", typeof(object))]

	///<summary>
	///method GetPointCount
	///</summary>
	public class GetPointsCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPointsCount);

		}
	}


	[NVP_Manifest(
		Text = "method GetHeightAtPoint", 
		ViewType = "Modifier")]
	[NodeInput("MDSLEarth", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("Result", typeof(System.Object))]

	///<summary>
	///method GetHeightAtPoint
	///</summary>
	public class GetPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetPoint(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method GetStation", 
		ViewType = "Modifier")]
	[NodeInput("MDSLEarth", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]
	[NodeInput("Value", typeof(System.String))]

	///<summary>
	///method GetStation
	///</summary>
	public class GetStation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetStation(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method owner", 
		ViewType = "Data")]
	[NodeInput("MDSLEarth", typeof(object))]

	///<summary>
	///method owner
	///</summary>
	public class owner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.owner);

		}
	}
}
