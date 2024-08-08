using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IURSApplication Interface
///</summary>
namespace mdsURSLib.URSApplication 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class URSApplication_Constructor : INode 
	{
		public mdsURSLib.IURSApplication _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsURSLib.IURSApplication;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class URSApplication_ConstructorCast : INode 
	{
		public mdsURSLib.IURSApplication _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsURSLib.IURSApplication;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "method CreateReport", 
		ViewType = "Data")]
	[NodeInput("URSApplication", typeof(object))]
	[NodeInput("Profile", typeof(System.Object))]

	///<summary>
	///method CreateReport
	///</summary>
	public class CreateReport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateReport(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "method BindData", 
		ViewType = "Modifier")]
	[NodeInput("URSApplication", typeof(object))]
	[NodeInput("DataSource", typeof(System.Object))]
	[NodeInput("DataOutputObject", typeof(System.Object))]
	[NodeInput("GraphicsBinding", typeof(System.Object))]

	///<summary>
	///method BindData
	///</summary>
	public class BindData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BindData(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method Query", 
		ViewType = "Data")]
	[NodeInput("URSApplication", typeof(object))]
	[NodeInput("pDataSource", typeof(System.Object))]
	[NodeInput("Query", typeof(System.String))]

	///<summary>
	///method Query
	///</summary>
	public class Query : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Query(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "method BindAttributeData", 
		ViewType = "Modifier")]
	[NodeInput("URSApplication", typeof(object))]
	[NodeInput("DataSource", typeof(System.Object))]
	[NodeInput("BlockReference", typeof(System.Object))]
	[NodeInput("AttrName", typeof(System.String))]
	[NodeInput("Query", typeof(System.String))]
	[NodeInput("GraphicsBinding", typeof(System.Object))]

	///<summary>
	///method BindAttributeData
	///</summary>
	public class BindAttributeData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BindAttributeData(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value);
			return null;
		}
	}
}
