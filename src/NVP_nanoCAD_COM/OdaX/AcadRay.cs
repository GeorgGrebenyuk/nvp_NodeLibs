using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a semi-infinite line entity
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadRay 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadRay_Constructor : INode 
	{
		public OdaX.IAcadRay _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadRay;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadRay_ConstructorCast : INode 
	{
		public OdaX.IAcadRay _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadRay;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the start point of a ray.", 
		ViewType = "Data")]
	[NodeInput("AcadRay", typeof(object))]

	///<summary>
	///Specifies or returns the start point of a ray.
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
		Text = "Specifies or returns the start point of a ray.", 
		ViewType = "Modifier")]
	[NodeInput("AcadRay", typeof(object))]
	[NodeInput("BasePoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the start point of a ray.
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
		Text = "Specifies or returns the second point of a ray.", 
		ViewType = "Data")]
	[NodeInput("AcadRay", typeof(object))]

	///<summary>
	///Specifies or returns the second point of a ray.
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
		Text = "Specifies or returns the second point of a ray.", 
		ViewType = "Modifier")]
	[NodeInput("AcadRay", typeof(object))]
	[NodeInput("SecondPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the second point of a ray.
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
		Text = "Specifies or returns the direction vector of a ray.", 
		ViewType = "Data")]
	[NodeInput("AcadRay", typeof(object))]

	///<summary>
	///Specifies or returns the direction vector of a ray.
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
		Text = "Specifies or returns the direction vector of a ray.", 
		ViewType = "Modifier")]
	[NodeInput("AcadRay", typeof(object))]
	[NodeInput("dirVector", typeof(System.Object))]

	///<summary>
	///Specifies or returns the direction vector of a ray.
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
}
