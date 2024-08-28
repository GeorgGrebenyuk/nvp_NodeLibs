using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSAxis Interface
///</summary>
namespace NVP_ModelStudio_COM._mdsURSLib.MDSAxis 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSAxis_Constructor : INode 
	{
		public mdsURSLib.IMDSAxis _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsURSLib.IMDSAxis;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSAxis_ConstructorCast : INode 
	{
		public mdsURSLib.IMDSAxis _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsURSLib.IMDSAxis;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Наименование сетки", 
		ViewType = "Data")]
	[NodeInput("MDSAxis", typeof(object))]

	///<summary>
	///Наименование сетки
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
		Text = "Наименование сетки", 
		ViewType = "Modifier")]
	[NodeInput("MDSAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Наименование сетки
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Параметры сетки", 
		ViewType = "Data")]
	[NodeInput("MDSAxis", typeof(object))]

	///<summary>
	///Параметры сетки
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
		Text = "Параметры сетки", 
		ViewType = "Modifier")]
	[NodeInput("MDSAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Параметры сетки
	///</summary>
	public class Set_Parameters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Parameters = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Начало координат", 
		ViewType = "Data")]
	[NodeInput("MDSAxis", typeof(object))]

	///<summary>
	///Начало координат
	///</summary>
	public class Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Origin);

		}
	}


	[NVP_Manifest(
		Text = "Начало координат", 
		ViewType = "Modifier")]
	[NodeInput("MDSAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Начало координат
	///</summary>
	public class Set_Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Origin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Стиль текста", 
		ViewType = "Data")]
	[NodeInput("MDSAxis", typeof(object))]

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
	[NodeInput("MDSAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

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
		Text = "Размер текста", 
		ViewType = "Data")]
	[NodeInput("MDSAxis", typeof(object))]

	///<summary>
	///Размер текста
	///</summary>
	public class TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextHeight);

		}
	}


	[NVP_Manifest(
		Text = "Размер текста", 
		ViewType = "Modifier")]
	[NodeInput("MDSAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Размер текста
	///</summary>
	public class Set_TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextHeight = inputs[1].Value;
			return null;
		}
	}
}
