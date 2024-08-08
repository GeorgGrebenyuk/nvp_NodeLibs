using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSViewportDef Interface
///</summary>
namespace mdsUnitsLib.MDSViewportDef 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSViewportDef_Constructor : INode 
	{
		public mdsUnitsLib.IMDSViewportDef _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IMDSViewportDef;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSViewportDef_ConstructorCast : INode 
	{
		public mdsUnitsLib.IMDSViewportDef _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IMDSViewportDef;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Наименование видового куба", 
		ViewType = "Data")]
	[NodeInput("MDSViewportDef", typeof(object))]

	///<summary>
	///Наименование видового куба
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
		Text = "Наименование видового куба", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportDef", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Наименование видового куба
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
		Text = "Тип видового куба", 
		ViewType = "Data")]
	[NodeInput("MDSViewportDef", typeof(object))]

	///<summary>
	///Тип видового куба
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
		Text = "Тип видового куба", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportDef", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип видового куба
	///</summary>
	public class Set_ViewportType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewportType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Базовая точка", 
		ViewType = "Data")]
	[NodeInput("MDSViewportDef", typeof(object))]

	///<summary>
	///Базовая точка
	///</summary>
	public class BasePoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BasePoint);

		}
	}


	[NVP_Manifest(
		Text = "Базовая точка", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportDef", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Базовая точка
	///</summary>
	public class Set_BasePoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BasePoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Ширина", 
		ViewType = "Data")]
	[NodeInput("MDSViewportDef", typeof(object))]

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
	[NodeInput("MDSViewportDef", typeof(object))]
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
		Text = "Глубина", 
		ViewType = "Data")]
	[NodeInput("MDSViewportDef", typeof(object))]

	///<summary>
	///Глубина
	///</summary>
	public class Depth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Depth);

		}
	}


	[NVP_Manifest(
		Text = "Глубина", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportDef", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Глубина
	///</summary>
	public class Set_Depth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Depth = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Высота", 
		ViewType = "Data")]
	[NodeInput("MDSViewportDef", typeof(object))]

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
	[NodeInput("MDSViewportDef", typeof(object))]
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
		Text = "Признак обрезки вида по передней грани", 
		ViewType = "Data")]
	[NodeInput("MDSViewportDef", typeof(object))]

	///<summary>
	///Признак обрезки вида по передней грани
	///</summary>
	public class FrontClip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FrontClip);

		}
	}


	[NVP_Manifest(
		Text = "Признак обрезки вида по передней грани", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportDef", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Признак обрезки вида по передней грани
	///</summary>
	public class Set_FrontClip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FrontClip = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Признак обрезки вида по задней грани", 
		ViewType = "Data")]
	[NodeInput("MDSViewportDef", typeof(object))]

	///<summary>
	///Признак обрезки вида по задней грани
	///</summary>
	public class BackClip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackClip);

		}
	}


	[NVP_Manifest(
		Text = "Признак обрезки вида по задней грани", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportDef", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Признак обрезки вида по задней грани
	///</summary>
	public class Set_BackClip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackClip = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Текстовый стиль подписи", 
		ViewType = "Data")]
	[NodeInput("MDSViewportDef", typeof(object))]

	///<summary>
	///Текстовый стиль подписи
	///</summary>
	public class TextStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextStyleName);

		}
	}


	[NVP_Manifest(
		Text = "Текстовый стиль подписи", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportDef", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Текстовый стиль подписи
	///</summary>
	public class Set_TextStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextStyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Высота текста подписи", 
		ViewType = "Data")]
	[NodeInput("MDSViewportDef", typeof(object))]

	///<summary>
	///Высота текста подписи
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
		Text = "Высота текста подписи", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportDef", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Высота текста подписи
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
