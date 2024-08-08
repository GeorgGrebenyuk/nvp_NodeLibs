using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrIronBoltJoint Interface
///</summary>
namespace ironObjComLib.WrIronBoltJoint 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrIronBoltJoint_Constructor : INode 
	{
		public ironObjComLib.IWrIronBoltJoint _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrIronBoltJoint;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrIronBoltJoint_ConstructorCast : INode 
	{
		public ironObjComLib.IWrIronBoltJoint _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrIronBoltJoint;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

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
	[NodeInput("WrIronBoltJoint", typeof(object))]
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
		Text = "property Class", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Class
	///</summary>
	public class Class : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Class);

		}
	}


	[NVP_Manifest(
		Text = "property Class", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Class
	///</summary>
	public class Set_Class : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Class = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Array or Single creation type mode", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Array or Single creation type mode
	///</summary>
	public class ArrayMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrayMode);

		}
	}


	[NVP_Manifest(
		Text = "property Array or Single creation type mode", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("plVal", typeof(System.Object))]

	///<summary>
	///property Array or Single creation type mode
	///</summary>
	public class Set_ArrayMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrayMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property of Chess order", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property of Chess order
	///</summary>
	public class ChessMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ChessMode);

		}
	}


	[NVP_Manifest(
		Text = "property of Chess order", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("plMode", typeof(System.Object))]

	///<summary>
	///property of Chess order
	///</summary>
	public class Set_ChessMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ChessMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property of Strength of Chees order", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property of Strength of Chees order
	///</summary>
	public class Strength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Strength);

		}
	}


	[NVP_Manifest(
		Text = "property of Strength of Chees order", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("plMode", typeof(System.Object))]

	///<summary>
	///property of Strength of Chees order
	///</summary>
	public class Set_Strength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Strength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Rows count", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Rows count
	///</summary>
	public class Rows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rows);

		}
	}


	[NVP_Manifest(
		Text = "property Rows count", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("plRows", typeof(System.Object))]

	///<summary>
	///property Rows count
	///</summary>
	public class Set_Rows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rows = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Row distance", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Row distance
	///</summary>
	public class RowDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RowDistance);

		}
	}


	[NVP_Manifest(
		Text = "property Row distance", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("pdRowDist", typeof(System.Double))]

	///<summary>
	///property Row distance
	///</summary>
	public class Set_RowDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RowDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Columns count", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Columns count
	///</summary>
	public class Columns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Columns);

		}
	}


	[NVP_Manifest(
		Text = "property Columns count", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("plColumns", typeof(System.Object))]

	///<summary>
	///property Columns count
	///</summary>
	public class Set_Columns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Columns = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Column distance", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Column distance
	///</summary>
	public class ColumnDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColumnDistance);

		}
	}


	[NVP_Manifest(
		Text = "property Column distance", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("pdColumnDist", typeof(System.Double))]

	///<summary>
	///property Column distance
	///</summary>
	public class Set_ColumnDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColumnDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Length", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Length
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
		Text = "property Bolthead height", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Bolthead height
	///</summary>
	public class Boltheight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Boltheight);

		}
	}


	[NVP_Manifest(
		Text = "property Shim external diameter", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Shim external diameter
	///</summary>
	public class ShimExternalDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShimExternalDiameter);

		}
	}


	[NVP_Manifest(
		Text = "property Shim web diameter", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Shim web diameter
	///</summary>
	public class ShimWebDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShimWebDiameter);

		}
	}


	[NVP_Manifest(
		Text = "property Shim height", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Shim height
	///</summary>
	public class ShimHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShimHeight);

		}
	}


	[NVP_Manifest(
		Text = "property Nut diameter", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Nut diameter
	///</summary>
	public class NutDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NutDiameter);

		}
	}


	[NVP_Manifest(
		Text = "property Nut height", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Nut height
	///</summary>
	public class NutHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NutHeight);

		}
	}


	[NVP_Manifest(
		Text = "property Nut length", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Nut length
	///</summary>
	public class NutLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NutLength);

		}
	}


	[NVP_Manifest(
		Text = "property First nut was enabled", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property First nut was enabled
	///</summary>
	public class Nut1Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Nut1Enabled);

		}
	}


	[NVP_Manifest(
		Text = "property First nut was enabled", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property First nut was enabled
	///</summary>
	public class Set_Nut1Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Nut1Enabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Second nut was enabled", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Second nut was enabled
	///</summary>
	public class Nut2Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Nut2Enabled);

		}
	}


	[NVP_Manifest(
		Text = "property Second nut was enabled", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Second nut was enabled
	///</summary>
	public class Set_Nut2Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Nut2Enabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Shim bolthead was enabled", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Shim bolthead was enabled
	///</summary>
	public class ShimheadEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShimheadEnabled);

		}
	}


	[NVP_Manifest(
		Text = "property Shim bolthead was enabled", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Shim bolthead was enabled
	///</summary>
	public class Set_ShimheadEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShimheadEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Shim array count", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Shim array count
	///</summary>
	public class ShimArray : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShimArray);

		}
	}


	[NVP_Manifest(
		Text = "property Shim array count", 
		ViewType = "Modifier")]
	[NodeInput("WrIronBoltJoint", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Shim array count
	///</summary>
	public class Set_ShimArray : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShimArray = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Packet length", 
		ViewType = "Data")]
	[NodeInput("WrIronBoltJoint", typeof(object))]

	///<summary>
	///property Packet length
	///</summary>
	public class PackLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PackLength);

		}
	}
}
