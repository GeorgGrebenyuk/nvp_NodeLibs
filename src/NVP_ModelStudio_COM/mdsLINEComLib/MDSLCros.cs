using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Пересечение
///</summary>
namespace mdsLINEComLib.MDSLCros 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLCros_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLCros _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLCros;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLCros_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLCros _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLCros;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property Element
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
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Element
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
		Text = "property Position", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property Position
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
		Text = "property Position", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Position
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
		Text = "property HeightMark", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property HeightMark
	///</summary>
	public class HeightMark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HeightMark);

		}
	}


	[NVP_Manifest(
		Text = "property HeightMark", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property HeightMark
	///</summary>
	public class Set_HeightMark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HeightMark = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property DistGroundMark", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property DistGroundMark
	///</summary>
	public class DistGroundMark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DistGroundMark);

		}
	}


	[NVP_Manifest(
		Text = "property NearLeft", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property NearLeft
	///</summary>
	public class NearLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NearLeft);

		}
	}


	[NVP_Manifest(
		Text = "property NearLeft", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property NearLeft
	///</summary>
	public class Set_NearLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NearLeft = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property NearRight", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property NearRight
	///</summary>
	public class NearRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NearRight);

		}
	}


	[NVP_Manifest(
		Text = "property NearRight", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property NearRight
	///</summary>
	public class Set_NearRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NearRight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property MarkType", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property MarkType
	///</summary>
	public class MarkType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MarkType);

		}
	}


	[NVP_Manifest(
		Text = "property MarkType", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property MarkType
	///</summary>
	public class Set_MarkType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MarkType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property PosLineType", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property PosLineType
	///</summary>
	public class PosLineMark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PosLineMark);

		}
	}


	[NVP_Manifest(
		Text = "property PosLineType", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PosLineType
	///</summary>
	public class Set_PosLineMark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PosLineMark = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Scalability", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property Scalability
	///</summary>
	public class Scalability : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Scalability);

		}
	}


	[NVP_Manifest(
		Text = "property Scalability", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Scalability
	///</summary>
	public class Set_Scalability : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Scalability = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property NameBTR", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property NameBTR
	///</summary>
	public class NameBTR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NameBTR);

		}
	}


	[NVP_Manifest(
		Text = "property NameBTR", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property NameBTR
	///</summary>
	public class Set_NameBTR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NameBTR = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property ScaleH_BTR", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property ScaleH_BTR
	///</summary>
	public class ScaleH_BTR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleH_BTR);

		}
	}


	[NVP_Manifest(
		Text = "property ScaleH_BTR", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ScaleH_BTR
	///</summary>
	public class Set_ScaleH_BTR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleH_BTR = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property ScaleV_BTR", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property ScaleV_BTR
	///</summary>
	public class ScaleV_BTR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleV_BTR);

		}
	}


	[NVP_Manifest(
		Text = "property ScaleV_BTR", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ScaleV_BTR
	///</summary>
	public class Set_ScaleV_BTR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleV_BTR = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Radius", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property Radius
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
		Text = "property Radius", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Radius
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
		Text = "property DXLeft", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property DXLeft
	///</summary>
	public class DXLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DXLeft);

		}
	}


	[NVP_Manifest(
		Text = "property DXLeft", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property DXLeft
	///</summary>
	public class Set_DXLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DXLeft = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property DXRight", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property DXRight
	///</summary>
	public class DXRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DXRight);

		}
	}


	[NVP_Manifest(
		Text = "property DXRight", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property DXRight
	///</summary>
	public class Set_DXRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DXRight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property BindType", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property BindType
	///</summary>
	public class BindType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BindType);

		}
	}


	[NVP_Manifest(
		Text = "property BindType", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property BindType
	///</summary>
	public class Set_BindType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BindType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method wireInSpan", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///method wireInSpan
	///</summary>
	public class wireInSpan : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.wireInSpan);

		}
	}


	[NVP_Manifest(
		Text = "method prevTower", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///method prevTower
	///</summary>
	public class prevTower : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.prevTower);

		}
	}


	[NVP_Manifest(
		Text = "method nextTower", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///method nextTower
	///</summary>
	public class nextTower : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.nextTower);

		}
	}


	[NVP_Manifest(
		Text = "method isPrevTower", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///method isPrevTower
	///</summary>
	public class isPrevTower : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.isPrevTower);

		}
	}


	[NVP_Manifest(
		Text = "method isNextTower", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///method isNextTower
	///</summary>
	public class isNextTower : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.isNextTower);

		}
	}


	[NVP_Manifest(
		Text = "method isThereWireInSpan", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///method isThereWireInSpan
	///</summary>
	public class isThereWireInSpan : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.isThereWireInSpan);

		}
	}


	[NVP_Manifest(
		Text = "method TransientNumber", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///method TransientNumber
	///</summary>
	public class TransientNumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TransientNumber);

		}
	}


	[NVP_Manifest(
		Text = "method owner", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///method owner
	///</summary>
	public class owner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.owner);

		}
	}
}
