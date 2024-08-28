using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace NVP_ModelStudio_COM._mdsUnitsLib.MDSGrounding 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSGrounding_Constructor : INode 
	{
		public mdsUnitsLib.IMDSGrounding _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IMDSGrounding;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSGrounding_ConstructorCast : INode 
	{
		public mdsUnitsLib.IMDSGrounding _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IMDSGrounding;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Длина полосы", 
		ViewType = "Data")]
	[NodeInput("MDSGrounding", typeof(object))]

	///<summary>
	///Длина полосы
	///</summary>
	public class GetLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLength);

		}
	}


	[NVP_Manifest(
		Text = "Длина полосы, разделенная по отметке", 
		ViewType = "Data")]
	[NodeInput("MDSGrounding", typeof(object))]
	[NodeInput("fLevel", typeof(System.Double))]

	///<summary>
	///Длина полосы, разделенная по отметке
	///</summary>
	public class GetLengthSeparated : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLengthSeparated(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Площадь поверхности полосы", 
		ViewType = "Data")]
	[NodeInput("MDSGrounding", typeof(object))]

	///<summary>
	///Площадь поверхности полосы
	///</summary>
	public class GetArea : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetArea);

		}
	}


	[NVP_Manifest(
		Text = "Площадь поверхности полосы, разделенная по отметке", 
		ViewType = "Data")]
	[NodeInput("MDSGrounding", typeof(object))]
	[NodeInput("fLevel", typeof(System.Double))]

	///<summary>
	///Площадь поверхности полосы, разделенная по отметке
	///</summary>
	public class GetAreaSeparated : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAreaSeparated(inputs[1].Value));

		}
	}
}
