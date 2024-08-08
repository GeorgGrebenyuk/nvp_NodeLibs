using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSSectionMark Interface
///</summary>
namespace mdsURSLib.MDSSectionMark 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSSectionMark_Constructor : INode 
	{
		public mdsURSLib.IMDSSectionMark _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsURSLib.IMDSSectionMark;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSSectionMark_ConstructorCast : INode 
	{
		public mdsURSLib.IMDSSectionMark _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsURSLib.IMDSSectionMark;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Номер разреза", 
		ViewType = "Data")]
	[NodeInput("MDSSectionMark", typeof(object))]

	///<summary>
	///Номер разреза
	///</summary>
	public class SectNumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SectNumber);

		}
	}


	[NVP_Manifest(
		Text = "Номер разреза", 
		ViewType = "Modifier")]
	[NodeInput("MDSSectionMark", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Номер разреза
	///</summary>
	public class Set_SectNumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SectNumber = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Номер листа", 
		ViewType = "Data")]
	[NodeInput("MDSSectionMark", typeof(object))]

	///<summary>
	///Номер листа
	///</summary>
	public class PageNumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PageNumber);

		}
	}


	[NVP_Manifest(
		Text = "Номер листа", 
		ViewType = "Modifier")]
	[NodeInput("MDSSectionMark", typeof(object))]
	[NodeInput("pv", typeof(System.String))]

	///<summary>
	///Номер листа
	///</summary>
	public class Set_PageNumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PageNumber = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Тип", 
		ViewType = "Data")]
	[NodeInput("MDSSectionMark", typeof(object))]

	///<summary>
	///Тип
	///</summary>
	public class ViewportType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewportType);

		}
	}


	[NVP_Manifest(
		Text = "Стиль текста", 
		ViewType = "Data")]
	[NodeInput("MDSSectionMark", typeof(object))]

	///<summary>
	///Стиль текста
	///</summary>
	public class TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextStyle);

		}
	}


	[NVP_Manifest(
		Text = "Стиль текста", 
		ViewType = "Modifier")]
	[NodeInput("MDSSectionMark", typeof(object))]
	[NodeInput("pv", typeof(System.String))]

	///<summary>
	///Стиль текста
	///</summary>
	public class Set_TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextStyle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Высота номера разреза", 
		ViewType = "Data")]
	[NodeInput("MDSSectionMark", typeof(object))]

	///<summary>
	///Высота номера разреза
	///</summary>
	public class NumbTxtHght : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumbTxtHght);

		}
	}


	[NVP_Manifest(
		Text = "Высота номера разреза", 
		ViewType = "Modifier")]
	[NodeInput("MDSSectionMark", typeof(object))]
	[NodeInput("pv", typeof(System.Double))]

	///<summary>
	///Высота номера разреза
	///</summary>
	public class Set_NumbTxtHght : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NumbTxtHght = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Высота номера листа", 
		ViewType = "Data")]
	[NodeInput("MDSSectionMark", typeof(object))]

	///<summary>
	///Высота номера листа
	///</summary>
	public class PageTxtHght : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PageTxtHght);

		}
	}


	[NVP_Manifest(
		Text = "Высота номера листа", 
		ViewType = "Modifier")]
	[NodeInput("MDSSectionMark", typeof(object))]
	[NodeInput("pv", typeof(System.Double))]

	///<summary>
	///Высота номера листа
	///</summary>
	public class Set_PageTxtHght : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PageTxtHght = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Длина штриха", 
		ViewType = "Data")]
	[NodeInput("MDSSectionMark", typeof(object))]

	///<summary>
	///Длина штриха
	///</summary>
	public class StrokeLng : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StrokeLng);

		}
	}


	[NVP_Manifest(
		Text = "Длина штриха", 
		ViewType = "Modifier")]
	[NodeInput("MDSSectionMark", typeof(object))]
	[NodeInput("pv", typeof(System.Double))]

	///<summary>
	///Длина штриха
	///</summary>
	public class Set_StrokeLng : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StrokeLng = inputs[1].Value;
			return null;
		}
	}
}
