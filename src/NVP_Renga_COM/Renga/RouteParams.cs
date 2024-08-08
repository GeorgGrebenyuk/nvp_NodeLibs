using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.RouteParams 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class RouteParams_Constructor : INode 
	{
		public Renga.IRouteParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IRouteParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class RouteParams_ConstructorCast : INode 
	{
		public Renga.IRouteParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IRouteParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("RouteParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetContour : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetContour);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("RouteParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class SourceModelObjectId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SourceModelObjectId);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("RouteParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class TargetModelObjectId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TargetModelObjectId);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("RouteParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class SystemStyleId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SystemStyleId);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("RouteParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetJointCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetJointCount);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("RouteParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetJointParams : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetJointParams);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("RouteParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetObjectOnRouteCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetObjectOnRouteCount);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("RouteParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetObjectOnRoutePlacement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetObjectOnRoutePlacement);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("RouteParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetFlowSegmentCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetFlowSegmentCount);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("RouteParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetFlowSegmentPlacement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetFlowSegmentPlacement);

		}
	}
}
