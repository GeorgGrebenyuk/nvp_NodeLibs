using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IBOM interface
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.BOM 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BOM_Constructor : INode 
	{
		public McCOM2.IBOM _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IBOM;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BOM_ConstructorCast : INode 
	{
		public McCOM2.IBOM _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IBOM;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000005ba", 
		ViewType = "Data")]
	[NodeInput("BOM", typeof(object))]
	[NodeInput("nIndex", typeof(System.Object))]

	///<summary>
	///0x000005ba
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
		Text = "0x000005bb", 
		ViewType = "Data")]
	[NodeInput("BOM", typeof(object))]

	///<summary>
	///0x000005bb
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
		Text = "0x000005bc", 
		ViewType = "Data")]
	[NodeInput("BOM", typeof(object))]

	///<summary>
	///0x000005bc
	///</summary>
	public class CreateRecord : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateRecord);

		}
	}


	[NVP_Manifest(
		Text = "0x000005bd", 
		ViewType = "Modifier")]
	[NodeInput("BOM", typeof(object))]
	[NodeInput("nIndex", typeof(System.Object))]

	///<summary>
	///0x000005bd
	///</summary>
	public class RemoveRecord : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveRecord(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005be", 
		ViewType = "Data")]
	[NodeInput("BOM", typeof(object))]

	///<summary>
	///0x000005be
	///</summary>
	public class Style : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Style);

		}
	}


	[NVP_Manifest(
		Text = "0x000005be", 
		ViewType = "Modifier")]
	[NodeInput("BOM", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x000005be
	///</summary>
	public class Set_Style : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Style = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005bf", 
		ViewType = "Data")]
	[NodeInput("BOM", typeof(object))]

	///<summary>
	///0x000005bf
	///</summary>
	public class Sections : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Sections);

		}
	}


	[NVP_Manifest(
		Text = "0x000005c0", 
		ViewType = "Modifier")]
	[NodeInput("BOM", typeof(object))]

	///<summary>
	///0x000005c0
	///</summary>
	public class Edit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Edit();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005c1", 
		ViewType = "Modifier")]
	[NodeInput("BOM", typeof(object))]
	[NodeInput("fUpdateRelatedObjects", typeof(System.Object))]

	///<summary>
	///0x000005c1
	///</summary>
	public class Update : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Update(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005c7", 
		ViewType = "Modifier")]
	[NodeInput("BOM", typeof(object))]
	[NodeInput("bstrPartition", typeof(System.String))]
	[NodeInput("iBomPerformance", typeof(System.Object))]

	///<summary>
	///0x000005c7
	///</summary>
	public class Sort : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Sort(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005d7", 
		ViewType = "Modifier")]
	[NodeInput("BOM", typeof(object))]

	///<summary>
	///0x000005d7
	///</summary>
	public class Renumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Renumber();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005c3", 
		ViewType = "Modifier")]
	[NodeInput("BOM", typeof(object))]
	[NodeInput("McCOM2.BOMExportFormat", typeof(System.Object))]
	[NodeInput("vParams", typeof(System.Object))]

	///<summary>
	///0x000005c3
	///</summary>
	public class Export : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Export(((McCOM2.BOMExportFormat)inputs[1].Value),inputs[2].Value);
			return null;
		}
	}
}
