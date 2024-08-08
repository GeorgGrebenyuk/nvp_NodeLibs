using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a construction line that is infinite in both directions
///</summary>
namespace OdaX.AcadXline 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadXline_Constructor : INode 
	{
		public OdaX.IAcadXline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadXline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadXline_ConstructorCast : INode 
	{
		public OdaX.IAcadXline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadXline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specify the X, Y, Z coordinate for the base point of the Xline or use the Pick Point button to set X, Y, Z values simultaneously", 
		ViewType = "Data")]
	[NodeInput("AcadXline", typeof(object))]

	///<summary>
	///Specify the X, Y, Z coordinate for the base point of the Xline or use the Pick Point button to set X, Y, Z values simultaneously
	///</summary>
	public class BasePoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BasePoint);

		}
	}


	[NVP_Manifest(
		Text = "Specify the X, Y, Z coordinate for the base point of the Xline or use the Pick Point button to set X, Y, Z values simultaneously", 
		ViewType = "Modifier")]
	[NodeInput("AcadXline", typeof(object))]
	[NodeInput("BasePoint", typeof(System.Object))]

	///<summary>
	///Specify the X, Y, Z coordinate for the base point of the Xline or use the Pick Point button to set X, Y, Z values simultaneously
	///</summary>
	public class Set_BasePoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BasePoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specify the X, Y, Z coordinate for the second point of the Xline or use the Pick Point button to set X, Y, Z values simultaneously", 
		ViewType = "Data")]
	[NodeInput("AcadXline", typeof(object))]

	///<summary>
	///Specify the X, Y, Z coordinate for the second point of the Xline or use the Pick Point button to set X, Y, Z values simultaneously
	///</summary>
	public class SecondPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SecondPoint);

		}
	}


	[NVP_Manifest(
		Text = "Specify the X, Y, Z coordinate for the second point of the Xline or use the Pick Point button to set X, Y, Z values simultaneously", 
		ViewType = "Modifier")]
	[NodeInput("AcadXline", typeof(object))]
	[NodeInput("SecondPoint", typeof(System.Object))]

	///<summary>
	///Specify the X, Y, Z coordinate for the second point of the Xline or use the Pick Point button to set X, Y, Z values simultaneously
	///</summary>
	public class Set_SecondPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SecondPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specify the X, Y, Z coordinate for the direction vector of the Xline", 
		ViewType = "Data")]
	[NodeInput("AcadXline", typeof(object))]

	///<summary>
	///Specify the X, Y, Z coordinate for the direction vector of the Xline
	///</summary>
	public class DirectionVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DirectionVector);

		}
	}


	[NVP_Manifest(
		Text = "Specify the X, Y, Z coordinate for the direction vector of the Xline", 
		ViewType = "Modifier")]
	[NodeInput("AcadXline", typeof(object))]
	[NodeInput("dirVector", typeof(System.Object))]

	///<summary>
	///Specify the X, Y, Z coordinate for the direction vector of the Xline
	///</summary>
	public class Set_DirectionVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DirectionVector = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Creates a new entity object by offsetting the Xline by a specified distance", 
		ViewType = "Data")]
	[NodeInput("AcadXline", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Creates a new entity object by offsetting the Xline by a specified distance
	///</summary>
	public class Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Offset(inputs[1].Value));

		}
	}
}
