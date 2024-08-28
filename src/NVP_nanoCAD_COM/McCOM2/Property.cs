using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Object property interface
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.Property 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Property_Constructor : INode 
	{
		public McCOM2.IProperty _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IProperty;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Property_ConstructorCast : INode 
	{
		public McCOM2.IProperty _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IProperty;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000000b5", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000b5
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Text = "0x000000ad", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000ad
	///</summary>
	public class Alias : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Alias);

		}
	}


	[NVP_Manifest(
		Text = "0x000000b8", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000b8
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
		Text = "0x000000b1", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000b1
	///</summary>
	public class Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Description);

		}
	}


	[NVP_Manifest(
		Text = "0x000000b0", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000b0
	///</summary>
	public class Category : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Category);

		}
	}


	[NVP_Manifest(
		Text = "0x000000b2", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000b2
	///</summary>
	public class Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Enabled);

		}
	}


	[NVP_Manifest(
		Text = "0x000000b6", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000b6
	///</summary>
	public class Object : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Object);

		}
	}


	[NVP_Manifest(
		Text = "0x000000b9", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000b9
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
		Text = "0x000000b9", 
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("pResult", typeof(System.Object))]

	///<summary>
	///0x000000b9
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
		Text = "0x000000af", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000af
	///</summary>
	public class Bounds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bounds);

		}
	}


	[NVP_Manifest(
		Text = "0x000000b7", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000b7
	///</summary>
	public class Raw : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Raw);

		}
	}


	[NVP_Manifest(
		Text = "0x000000b4", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000b4
	///</summary>
	public class Items : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Items);

		}
	}


	[NVP_Manifest(
		Text = "0x000000b3", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000b3
	///</summary>
	public class Global : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Global);

		}
	}


	[NVP_Manifest(
		Text = "0x000000ae", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000ae
	///</summary>
	public class Binded : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Binded);

		}
	}


	[NVP_Manifest(
		Text = "0x000000ae", 
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("pvbResult", typeof(System.Object))]

	///<summary>
	///0x000000ae
	///</summary>
	public class Set_Binded : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Binded = inputs[1].Value;
			return null;
		}
	}
}
