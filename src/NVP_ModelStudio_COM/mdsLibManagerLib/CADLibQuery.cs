using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ICADLibQuery Interface
///</summary>
namespace NVP_ModelStudio_COM._mdsLibManagerLib.CADLibQuery 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class CADLibQuery_Constructor : INode 
	{
		public mdsLibManagerLib.ICADLibQuery _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLibManagerLib.ICADLibQuery;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class CADLibQuery_ConstructorCast : INode 
	{
		public mdsLibManagerLib.ICADLibQuery _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLibManagerLib.ICADLibQuery;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "method AddCondition", 
		ViewType = "Modifier")]
	[NodeInput("CADLibQuery", typeof(object))]
	[NodeInput("ParamName", typeof(System.String))]
	[NodeInput("Relation", typeof(System.Object))]
	[NodeInput("Value", typeof(System.String))]

	///<summary>
	///method AddCondition
	///</summary>
	public class AddCondition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddCondition(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method Execute", 
		ViewType = "Data")]
	[NodeInput("CADLibQuery", typeof(object))]

	///<summary>
	///method Execute
	///</summary>
	public class Execute2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Execute);

		}
	}


	[NVP_Manifest(
		Text = "method Search", 
		ViewType = "Data")]
	[NodeInput("CADLibQuery", typeof(object))]
	[NodeInput("hWndParent", typeof(System.Object))]
	[NodeInput("bsCaption", typeof(System.String))]

	///<summary>
	///method Search
	///</summary>
	public class Search : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Search(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "method SelectObjects", 
		ViewType = "Data")]
	[NodeInput("CADLibQuery", typeof(object))]
	[NodeInput("hWndParent", typeof(System.Object))]
	[NodeInput("Caption", typeof(System.String))]
	[NodeInput("Options", typeof(System.Object))]

	///<summary>
	///method SelectObjects
	///</summary>
	public class SelectObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SelectObjects(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}
}
