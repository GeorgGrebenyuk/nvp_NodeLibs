using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Assembly command
///</summary>
namespace nanoCAD.ACommand 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ACommand_Constructor : INode 
	{
		public nanoCAD.IACommand _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.IACommand;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ACommand_ConstructorCast : INode 
	{
		public nanoCAD.IACommand _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.IACommand;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "command type", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///command type
	///</summary>
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	[NVP_Manifest(
		Text = "command type", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///command type
	///</summary>
	public class ID : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ID);

		}
	}


	[NVP_Manifest(
		Text = "command type", 
		ViewType = "Modifier")]
	[NodeInput("ACommand", typeof(object))]
	[NodeInput("ID", typeof(System.Object))]

	///<summary>
	///command type
	///</summary>
	public class Set_ID : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ID = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "internal name", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///internal name
	///</summary>
	public class InternalName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InternalName);

		}
	}


	[NVP_Manifest(
		Text = "disp name", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///disp name
	///</summary>
	public class DispName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DispName);

		}
	}


	[NVP_Manifest(
		Text = "weight", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///weight
	///</summary>
	public class Weight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Weight);

		}
	}


	[NVP_Manifest(
		Text = "launch weight", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///launch weight
	///</summary>
	public class LaunchWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LaunchWeight);

		}
	}


	[NVP_Manifest(
		Text = "StatusString", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///StatusString
	///</summary>
	public class StatusString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StatusString);

		}
	}


	[NVP_Manifest(
		Text = "tooltip string", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///tooltip string
	///</summary>
	public class ToolTip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToolTip);

		}
	}


	[NVP_Manifest(
		Text = "caps", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///caps
	///</summary>
	public class Caps : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Caps);

		}
	}


	[NVP_Manifest(
		Text = "menu string", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///menu string
	///</summary>
	public class MenuText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MenuText);

		}
	}


	[NVP_Manifest(
		Text = "menu group", 
		ViewType = "Data")]
	[NodeInput("ACommand", typeof(object))]

	///<summary>
	///menu group
	///</summary>
	public class MenuGroup : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MenuGroup);

		}
	}


	[NVP_Manifest(
		Text = "Run command", 
		ViewType = "Modifier")]
	[NodeInput("ACommand", typeof(object))]
	[NodeInput("helper", typeof(System.Object))]

	///<summary>
	///Run command
	///</summary>
	public class Run : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Run(inputs[1].Value);
			return null;
		}
	}
}
