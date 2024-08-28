using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ImstRoutePrototype Interface
///</summary>
namespace NVP_ModelStudio_COM._mstRouteCOMLib.mstRoutePrototype 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class mstRoutePrototype_Constructor : INode 
	{
		public mstRouteCOMLib.ImstRoutePrototype _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mstRouteCOMLib.ImstRoutePrototype;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class mstRoutePrototype_ConstructorCast : INode 
	{
		public mstRouteCOMLib.ImstRoutePrototype _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mstRouteCOMLib.ImstRoutePrototype;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "StartPoint", 
		ViewType = "Data")]
	[NodeInput("mstRoutePrototype", typeof(object))]

	///<summary>
	///StartPoint
	///</summary>
	public class StartPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartPosition);

		}
	}


	[NVP_Manifest(
		Text = "StartPoint", 
		ViewType = "Modifier")]
	[NodeInput("mstRoutePrototype", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///StartPoint
	///</summary>
	public class Set_StartPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "EndPoint", 
		ViewType = "Data")]
	[NodeInput("mstRoutePrototype", typeof(object))]

	///<summary>
	///EndPoint
	///</summary>
	public class EndPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndPosition);

		}
	}


	[NVP_Manifest(
		Text = "EndPoint", 
		ViewType = "Modifier")]
	[NodeInput("mstRoutePrototype", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///EndPoint
	///</summary>
	public class Set_EndPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("mstRoutePrototype", typeof(object))]

	///<summary>
	///Параметры
	///</summary>
	public class Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Element);

		}
	}


	[NVP_Manifest(
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("mstRoutePrototype", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Параметры
	///</summary>
	public class Set_Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Element = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Полки", 
		ViewType = "Data")]
	[NodeInput("mstRoutePrototype", typeof(object))]

	///<summary>
	///Полки
	///</summary>
	public class Shelves : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Shelves);

		}
	}


	[NVP_Manifest(
		Text = "Полки", 
		ViewType = "Modifier")]
	[NodeInput("mstRoutePrototype", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Полки
	///</summary>
	public class Set_Shelves : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Shelves = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Normal", 
		ViewType = "Data")]
	[NodeInput("mstRoutePrototype", typeof(object))]

	///<summary>
	///Normal
	///</summary>
	public class Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Normal);

		}
	}


	[NVP_Manifest(
		Text = "Normal", 
		ViewType = "Modifier")]
	[NodeInput("mstRoutePrototype", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Normal
	///</summary>
	public class Set_Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Normal = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Длина", 
		ViewType = "Data")]
	[NodeInput("mstRoutePrototype", typeof(object))]

	///<summary>
	///Длина
	///</summary>
	public class Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Length);

		}
	}


	[NVP_Manifest(
		Text = "Длина", 
		ViewType = "Modifier")]
	[NodeInput("mstRoutePrototype", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Длина
	///</summary>
	public class Set_Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Length = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Радиус", 
		ViewType = "Data")]
	[NodeInput("mstRoutePrototype", typeof(object))]

	///<summary>
	///Радиус
	///</summary>
	public class Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Radius);

		}
	}


	[NVP_Manifest(
		Text = "Радиус", 
		ViewType = "Modifier")]
	[NodeInput("mstRoutePrototype", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Радиус
	///</summary>
	public class Set_Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Radius = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Тип профиля", 
		ViewType = "Data")]
	[NodeInput("mstRoutePrototype", typeof(object))]

	///<summary>
	///Тип профиля
	///</summary>
	public class ProfileType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProfileType);

		}
	}


	[NVP_Manifest(
		Text = "Тип профиля", 
		ViewType = "Modifier")]
	[NodeInput("mstRoutePrototype", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип профиля
	///</summary>
	public class Set_ProfileType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ProfileType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Плоскость изгиба", 
		ViewType = "Data")]
	[NodeInput("mstRoutePrototype", typeof(object))]

	///<summary>
	///Плоскость изгиба
	///</summary>
	public class BendType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BendType);

		}
	}


	[NVP_Manifest(
		Text = "Плоскость изгиба", 
		ViewType = "Modifier")]
	[NodeInput("mstRoutePrototype", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Плоскость изгиба
	///</summary>
	public class Set_BendType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BendType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Показывать направление", 
		ViewType = "Data")]
	[NodeInput("mstRoutePrototype", typeof(object))]

	///<summary>
	///Показывать направление
	///</summary>
	public class ShowDir : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowDir);

		}
	}


	[NVP_Manifest(
		Text = "Показывать направление", 
		ViewType = "Modifier")]
	[NodeInput("mstRoutePrototype", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Показывать направление
	///</summary>
	public class Set_ShowDir : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShowDir = inputs[1].Value;
			return null;
		}
	}
}
