using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Text formatting engine interface
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.Text 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Text_Constructor : INode 
	{
		public McCOM2.IText _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IText;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Text_ConstructorCast : INode 
	{
		public McCOM2.IText _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IText;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x00000576", 
		ViewType = "Data")]
	[NodeInput("Text", typeof(object))]

	///<summary>
	///0x00000576
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
		Text = "0x00000576", 
		ViewType = "Modifier")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("pbstrText", typeof(System.String))]

	///<summary>
	///0x00000576
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
		Text = "0x00000573", 
		ViewType = "Data")]
	[NodeInput("Text", typeof(object))]

	///<summary>
	///0x00000573
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
		Text = "0x00000573", 
		ViewType = "Modifier")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("pbstrRawText", typeof(System.String))]

	///<summary>
	///0x00000573
	///</summary>
	public class Set_Raw : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Raw = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000572", 
		ViewType = "Data")]
	[NodeInput("Text", typeof(object))]

	///<summary>
	///0x00000572
	///</summary>
	public class Native : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Native);

		}
	}


	[NVP_Manifest(
		Text = "0x00000572", 
		ViewType = "Modifier")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("pbstrNative", typeof(System.String))]

	///<summary>
	///0x00000572
	///</summary>
	public class Set_Native : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Native = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000575", 
		ViewType = "Data")]
	[NodeInput("Text", typeof(object))]

	///<summary>
	///0x00000575
	///</summary>
	public class Simple : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Simple);

		}
	}


	[NVP_Manifest(
		Text = "0x00000574", 
		ViewType = "Data")]
	[NodeInput("Text", typeof(object))]

	///<summary>
	///0x00000574
	///</summary>
	public class RichEdit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RichEdit);

		}
	}


	[NVP_Manifest(
		Text = "0x0000056e", 
		ViewType = "Modifier")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("bstrSubscript", typeof(System.String))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000056e
	///</summary>
	public class InsertSub : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertSub(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000056f", 
		ViewType = "Modifier")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("bstrSuperscript", typeof(System.String))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000056f
	///</summary>
	public class InsertSup : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertSup(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000056b", 
		ViewType = "Modifier")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("bstrText", typeof(System.String))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000056b
	///</summary>
	public class Insert : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Insert(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000056d", 
		ViewType = "Modifier")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("rNumber", typeof(System.Double))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000056d
	///</summary>
	public class InsertNum : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertNum(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000056c", 
		ViewType = "Modifier")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("bstrUpper", typeof(System.String))]
	[NodeInput("bstrLower", typeof(System.String))]
	[NodeInput("vbLine", typeof(System.Object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000056c
	///</summary>
	public class InsertDivision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertDivision(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000569", 
		ViewType = "Modifier")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("idsFrom", typeof(System.Object))]
	[NodeInput("nCount", typeof(System.Object))]

	///<summary>
	///0x00000569
	///</summary>
	public class Delete : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Delete(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000571", 
		ViewType = "Data")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("bstrDelimiter", typeof(System.String))]

	///<summary>
	///0x00000571
	///</summary>
	public class Split : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Split(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x0000056a", 
		ViewType = "Data")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("bstrSubstring", typeof(System.String))]
	[NodeInput("Start", typeof(System.Object))]
	[NodeInput("vbMatchCase", typeof(System.Object))]

	///<summary>
	///0x0000056a
	///</summary>
	public class Find : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Find(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x00000570", 
		ViewType = "Data")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("bstrWhat", typeof(System.String))]
	[NodeInput("bstrWith", typeof(System.String))]
	[NodeInput("vbMatchCase", typeof(System.Object))]

	///<summary>
	///0x00000570
	///</summary>
	public class Replace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Replace(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}
}
