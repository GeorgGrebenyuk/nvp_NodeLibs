using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.DropDownButton 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class DropDownButton_Constructor : INode 
	{
		public Renga.IDropDownButton _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IDropDownButton;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class DropDownButton_ConstructorCast : INode 
	{
		public Renga.IDropDownButton _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IDropDownButton;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("DropDownButton", typeof(object))]
	[NodeInput("pAction", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AddAction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddAction(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("DropDownButton", typeof(object))]

	///<summary>
	///
	///</summary>
	public class AddSeparator : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddSeparator();
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("DropDownButton", typeof(object))]
	[NodeInput("rhs", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Icon : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Icon = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("DropDownButton", typeof(object))]
	[NodeInput("pToolTip", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_ToolTip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToolTip = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("DropDownButton", typeof(object))]

	///<summary>
	///
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
		ViewType = "Data")]
	[NodeInput("DropDownButton", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("DropDownButton", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IdS);

		}
	}
}
