using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace mstRouteCOMLib.mstRouteShelf 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class mstRouteShelf_Constructor : INode 
	{
		public mstRouteCOMLib.ImstRouteShelf _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mstRouteCOMLib.ImstRouteShelf;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class mstRouteShelf_ConstructorCast : INode 
	{
		public mstRouteCOMLib.ImstRouteShelf _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mstRouteCOMLib.ImstRouteShelf;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Параметры полки", 
		ViewType = "Data")]
	[NodeInput("mstRouteShelf", typeof(object))]

	///<summary>
	///Параметры полки
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
		Text = "Номер полки", 
		ViewType = "Data")]
	[NodeInput("mstRouteShelf", typeof(object))]

	///<summary>
	///Номер полки
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
		Text = "Ширина", 
		ViewType = "Data")]
	[NodeInput("mstRouteShelf", typeof(object))]

	///<summary>
	///Ширина
	///</summary>
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	[NVP_Manifest(
		Text = "Ширина", 
		ViewType = "Modifier")]
	[NodeInput("mstRouteShelf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Ширина
	///</summary>
	public class Set_Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Width = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Высота", 
		ViewType = "Data")]
	[NodeInput("mstRouteShelf", typeof(object))]

	///<summary>
	///Высота
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	[NVP_Manifest(
		Text = "Высота", 
		ViewType = "Modifier")]
	[NodeInput("mstRouteShelf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Высота
	///</summary>
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Смещение от оси вправо-влево", 
		ViewType = "Data")]
	[NodeInput("mstRouteShelf", typeof(object))]

	///<summary>
	///Смещение от оси вправо-влево
	///</summary>
	public class Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Offset);

		}
	}


	[NVP_Manifest(
		Text = "Смещение от оси вправо-влево", 
		ViewType = "Modifier")]
	[NodeInput("mstRouteShelf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Смещение от оси вправо-влево
	///</summary>
	public class Set_Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Offset = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Смещение от оси вверх-вниз", 
		ViewType = "Data")]
	[NodeInput("mstRouteShelf", typeof(object))]

	///<summary>
	///Смещение от оси вверх-вниз
	///</summary>
	public class Elevation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Elevation);

		}
	}


	[NVP_Manifest(
		Text = "Смещение от оси вверх-вниз", 
		ViewType = "Modifier")]
	[NodeInput("mstRouteShelf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Смещение от оси вверх-вниз
	///</summary>
	public class Set_Elevation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Elevation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Резерв", 
		ViewType = "Data")]
	[NodeInput("mstRouteShelf", typeof(object))]

	///<summary>
	///Резерв
	///</summary>
	public class Reserve : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Reserve);

		}
	}


	[NVP_Manifest(
		Text = "Резерв", 
		ViewType = "Modifier")]
	[NodeInput("mstRouteShelf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Резерв
	///</summary>
	public class Set_Reserve : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Reserve = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Подсветка", 
		ViewType = "Data")]
	[NodeInput("mstRouteShelf", typeof(object))]

	///<summary>
	///Подсветка
	///</summary>
	public class Hilite : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Hilite);

		}
	}


	[NVP_Manifest(
		Text = "Подсветка", 
		ViewType = "Modifier")]
	[NodeInput("mstRouteShelf", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Подсветка
	///</summary>
	public class Set_Hilite : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Hilite = inputs[1].Value;
			return null;
		}
	}
}
