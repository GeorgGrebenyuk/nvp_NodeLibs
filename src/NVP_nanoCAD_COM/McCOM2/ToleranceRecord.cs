using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Single line of SymTolerance designation
///</summary>
namespace McCOM2.ToleranceRecord 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ToleranceRecord_Constructor : INode 
	{
		public McCOM2.IToleranceRecord _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IToleranceRecord;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ToleranceRecord_ConstructorCast : INode 
	{
		public McCOM2.IToleranceRecord _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IToleranceRecord;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x00000592", 
		ViewType = "Data")]
	[NodeInput("ToleranceRecord", typeof(object))]

	///<summary>
	///0x00000592
	///</summary>
	public class Empty : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Empty);

		}
	}


	[NVP_Manifest(
		Text = "0x00000592", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceRecord", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x00000592
	///</summary>
	public class Set_Empty : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Empty = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000593", 
		ViewType = "Data")]
	[NodeInput("ToleranceRecord", typeof(object))]

	///<summary>
	///0x00000593
	///</summary>
	public class Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Value);

		}
	}


	[NVP_Manifest(
		Text = "0x00000593", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceRecord", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x00000593
	///</summary>
	public class Set_Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Value = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000594", 
		ViewType = "Data")]
	[NodeInput("ToleranceRecord", typeof(object))]

	///<summary>
	///0x00000594
	///</summary>
	public class Base : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Base);

		}
	}


	[NVP_Manifest(
		Text = "0x00000594", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceRecord", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x00000594
	///</summary>
	public class Set_Base : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Base = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000595", 
		ViewType = "Data")]
	[NodeInput("ToleranceRecord", typeof(object))]

	///<summary>
	///0x00000595
	///</summary>
	public class Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Text);

		}
	}


	[NVP_Manifest(
		Text = "0x00000595", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceRecord", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x00000595
	///</summary>
	public class Set_Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Text = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000596", 
		ViewType = "Data")]
	[NodeInput("ToleranceRecord", typeof(object))]

	///<summary>
	///0x00000596
	///</summary>
	public class Parameters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Parameters);

		}
	}


	[NVP_Manifest(
		Text = "0x00000597", 
		ViewType = "Data")]
	[NodeInput("ToleranceRecord", typeof(object))]

	///<summary>
	///0x00000597
	///</summary>
	public class Object : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Object);

		}
	}
}
