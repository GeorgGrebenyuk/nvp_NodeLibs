using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ApplicationEvents 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ApplicationEvents_Constructor : INode 
	{
		public Renga._IApplicationEvents _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga._IApplicationEvents;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ApplicationEvents_ConstructorCast : INode 
	{
		public Renga._IApplicationEvents _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga._IApplicationEvents;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("ApplicationEvents", typeof(object))]
	[NodeInput("pEvent", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class OnBeforeApplicationClose : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnBeforeApplicationClose(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("ApplicationEvents", typeof(object))]
	[NodeInput("pEvent", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class OnBeforeProjectClose : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnBeforeProjectClose(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("ApplicationEvents", typeof(object))]

	///<summary>
	///
	///</summary>
	public class OnProjectCreated : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnProjectCreated();
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("ApplicationEvents", typeof(object))]
	[NodeInput("filePath_", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class OnProjectOpened : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnProjectOpened(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("ApplicationEvents", typeof(object))]
	[NodeInput("filePath_", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class OnProjectSaved : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnProjectSaved(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("ApplicationEvents", typeof(object))]

	///<summary>
	///
	///</summary>
	public class OnProjectClosed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnProjectClosed();
			return null;
		}
	}
}
