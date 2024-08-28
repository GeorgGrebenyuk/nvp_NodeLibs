using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrAECBore Interface
///</summary>
namespace NVP_ModelStudio_COM._ironObjComLib.WrAECBore 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECBore_Constructor : INode 
	{
		public ironObjComLib.IWrAECBore _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrAECBore;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECBore_ConstructorCast : INode 
	{
		public ironObjComLib.IWrAECBore _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrAECBore;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("WrAECBore", typeof(object))]

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
	[NodeInput("WrAECBore", typeof(object))]
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
		Text = "Тип скважины", 
		ViewType = "Data")]
	[NodeInput("WrAECBore", typeof(object))]

	///<summary>
	///Тип скважины
	///</summary>
	public class BoreType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BoreType);

		}
	}


	[NVP_Manifest(
		Text = "Тип скважины", 
		ViewType = "Modifier")]
	[NodeInput("WrAECBore", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип скважины
	///</summary>
	public class Set_BoreType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BoreType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Объем,м3", 
		ViewType = "Data")]
	[NodeInput("WrAECBore", typeof(object))]

	///<summary>
	///Объем,м3
	///</summary>
	public class BoreVolume : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BoreVolume);

		}
	}


	[NVP_Manifest(
		Text = "Угол откоса, град", 
		ViewType = "Data")]
	[NodeInput("WrAECBore", typeof(object))]

	///<summary>
	///Угол откоса, град
	///</summary>
	public class BoreAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BoreAngle);

		}
	}


	[NVP_Manifest(
		Text = "Угол откоса, град", 
		ViewType = "Modifier")]
	[NodeInput("WrAECBore", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Угол откоса, град
	///</summary>
	public class Set_BoreAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BoreAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "До верха от базовой", 
		ViewType = "Data")]
	[NodeInput("WrAECBore", typeof(object))]

	///<summary>
	///До верха от базовой
	///</summary>
	public class BoreDepthTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BoreDepthTop);

		}
	}


	[NVP_Manifest(
		Text = "До верха от базовой", 
		ViewType = "Modifier")]
	[NodeInput("WrAECBore", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///До верха от базовой
	///</summary>
	public class Set_BoreDepthTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BoreDepthTop = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "До низа от базовой", 
		ViewType = "Data")]
	[NodeInput("WrAECBore", typeof(object))]

	///<summary>
	///До низа от базовой
	///</summary>
	public class BoreDepthBottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BoreDepthBottom);

		}
	}


	[NVP_Manifest(
		Text = "До низа от базовой", 
		ViewType = "Modifier")]
	[NodeInput("WrAECBore", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///До низа от базовой
	///</summary>
	public class Set_BoreDepthBottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BoreDepthBottom = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Размер 1", 
		ViewType = "Data")]
	[NodeInput("WrAECBore", typeof(object))]

	///<summary>
	///Размер 1
	///</summary>
	public class BoreSize1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BoreSize1);

		}
	}


	[NVP_Manifest(
		Text = "Размер 1", 
		ViewType = "Modifier")]
	[NodeInput("WrAECBore", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Размер 1
	///</summary>
	public class Set_BoreSize1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BoreSize1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Размер 2", 
		ViewType = "Data")]
	[NodeInput("WrAECBore", typeof(object))]

	///<summary>
	///Размер 2
	///</summary>
	public class BoreSize2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BoreSize2);

		}
	}


	[NVP_Manifest(
		Text = "Размер 2", 
		ViewType = "Modifier")]
	[NodeInput("WrAECBore", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Размер 2
	///</summary>
	public class Set_BoreSize2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BoreSize2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Диаметр", 
		ViewType = "Data")]
	[NodeInput("WrAECBore", typeof(object))]

	///<summary>
	///Диаметр
	///</summary>
	public class BoreDiam : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BoreDiam);

		}
	}


	[NVP_Manifest(
		Text = "Диаметр", 
		ViewType = "Modifier")]
	[NodeInput("WrAECBore", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Диаметр
	///</summary>
	public class Set_BoreDiam : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BoreDiam = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Угол в плане", 
		ViewType = "Data")]
	[NodeInput("WrAECBore", typeof(object))]

	///<summary>
	///Угол в плане
	///</summary>
	public class BoreAngleXY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BoreAngleXY);

		}
	}


	[NVP_Manifest(
		Text = "Угол в плане", 
		ViewType = "Modifier")]
	[NodeInput("WrAECBore", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Угол в плане
	///</summary>
	public class Set_BoreAngleXY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BoreAngleXY = inputs[1].Value;
			return null;
		}
	}
}
