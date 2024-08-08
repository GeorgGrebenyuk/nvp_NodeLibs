using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///McCOM application object
///</summary>
namespace McCOM2.Server 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Server_Constructor : INode 
	{
		public McCOM2.IServer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IServer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Server_ConstructorCast : INode 
	{
		public McCOM2.IServer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IServer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000000ca", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]

	///<summary>
	///0x000000ca
	///</summary>
	public class Properties : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Properties);

		}
	}


	[NVP_Manifest(
		Text = "0x000000cc", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]

	///<summary>
	///0x000000cc
	///</summary>
	public class Title : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Title);

		}
	}


	[NVP_Manifest(
		Text = "0x000000c8", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]

	///<summary>
	///0x000000c8
	///</summary>
	public class DimScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimScale);

		}
	}


	[NVP_Manifest(
		Text = "0x000000c8", 
		ViewType = "Modifier")]
	[NodeInput("Server", typeof(object))]
	[NodeInput("prDimScale", typeof(System.Double))]

	///<summary>
	///0x000000c8
	///</summary>
	public class Set_DimScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000000cd", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]

	///<summary>
	///0x000000cd
	///</summary>
	public class ViewScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewScale);

		}
	}


	[NVP_Manifest(
		Text = "0x000000cd", 
		ViewType = "Modifier")]
	[NodeInput("Server", typeof(object))]
	[NodeInput("prViewScale", typeof(System.Double))]

	///<summary>
	///0x000000cd
	///</summary>
	public class Set_ViewScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000000cb", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]

	///<summary>
	///0x000000cb
	///</summary>
	public class Scales : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Scales);

		}
	}


	[NVP_Manifest(
		Text = "0x000000c6", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]
	[NodeInput("rScale", typeof(System.Double))]

	///<summary>
	///0x000000c6
	///</summary>
	public class ScaleToStr : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleToStr(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x000000c5", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]
	[NodeInput("bstrScale", typeof(System.String))]

	///<summary>
	///0x000000c5
	///</summary>
	public class ScaleFromStr : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleFromStr(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x000000c9", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]
	[NodeInput("vID", typeof(System.Object))]

	///<summary>
	///0x000000c9
	///</summary>
	public class Object : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Object(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x000000c1", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]
	[NodeInput("bstrClass", typeof(System.String))]

	///<summary>
	///0x000000c1
	///</summary>
	public class CreateObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateObject(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x000000c3", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]
	[NodeInput("bstrClasses", typeof(System.Object))]
	[NodeInput("vProps", typeof(System.Object))]
	[NodeInput("rBoundBlock", typeof(System.Object))]

	///<summary>
	///0x000000c3
	///</summary>
	public class Query : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Query(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x000000c7", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]
	[NodeInput("bstrPropmt", typeof(System.String))]
	[NodeInput("bSingleObject", typeof(System.Object))]

	///<summary>
	///0x000000c7
	///</summary>
	public class Select : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Select(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x000000c4", 
		ViewType = "Modifier")]
	[NodeInput("Server", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]
	[NodeInput("bstrSubName", typeof(System.String))]
	[NodeInput("vScriptId", typeof(System.Object))]
	[NodeInput("bstrCLSID", typeof(System.String))]

	///<summary>
	///0x000000c4
	///</summary>
	public class RegisterCalculator : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RegisterCalculator(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000000c2", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]
	[NodeInput("bstrText", typeof(System.String))]
	[NodeInput("McCOM2.MessageIcon", typeof(System.Object))]
	[NodeInput("idParent", typeof(System.Object))]

	///<summary>
	///0x000000c2
	///</summary>
	public class Message : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Message(inputs[1].Value,((McCOM2.MessageIcon)inputs[2].Value),inputs[3].Value));

		}
	}
}
