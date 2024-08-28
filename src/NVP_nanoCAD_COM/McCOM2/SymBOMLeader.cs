using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///BOM posiiton mark
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.SymBOMLeader 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymBOMLeader_Constructor : INode 
	{
		public McCOM2.ISymBOMLeader _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymBOMLeader;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymBOMLeader_ConstructorCast : INode 
	{
		public McCOM2.ISymBOMLeader _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymBOMLeader;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000005ca", 
		ViewType = "Data")]
	[NodeInput("SymBOMLeader", typeof(object))]

	///<summary>
	///0x000005ca
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		Text = "0x000005ca", 
		ViewType = "Modifier")]
	[NodeInput("SymBOMLeader", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000005ca
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005cb", 
		ViewType = "Data")]
	[NodeInput("SymBOMLeader", typeof(object))]

	///<summary>
	///0x000005cb
	///</summary>
	public class TextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextPosition);

		}
	}


	[NVP_Manifest(
		Text = "0x000005cb", 
		ViewType = "Modifier")]
	[NodeInput("SymBOMLeader", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000005cb
	///</summary>
	public class Set_TextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005cc", 
		ViewType = "Data")]
	[NodeInput("SymBOMLeader", typeof(object))]

	///<summary>
	///0x000005cc
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Text = "0x000005cd", 
		ViewType = "Data")]
	[NodeInput("SymBOMLeader", typeof(object))]
	[NodeInput("nIndex", typeof(System.Object))]

	///<summary>
	///0x000005cd
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x000005ce", 
		ViewType = "Modifier")]
	[NodeInput("SymBOMLeader", typeof(object))]
	[NodeInput("pRecord", typeof(System.Object))]
	[NodeInput("pObject", typeof(System.Object))]
	[NodeInput("ppCreated", typeof(System.Object))]

	///<summary>
	///0x000005ce
	///</summary>
	public class CreateItem : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CreateItem(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005cf", 
		ViewType = "Modifier")]
	[NodeInput("SymBOMLeader", typeof(object))]
	[NodeInput("nItemIndex", typeof(System.Object))]

	///<summary>
	///0x000005cf
	///</summary>
	public class DeleteItem : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DeleteItem(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005d0", 
		ViewType = "Data")]
	[NodeInput("SymBOMLeader", typeof(object))]

	///<summary>
	///0x000005d0
	///</summary>
	public class BOM : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BOM);

		}
	}
}
