using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSLProfile Interface
///</summary>
namespace mdsLINEComLib.MDSLProfile 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLProfile_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLProfile _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLProfile;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLProfile_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLProfile _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLProfile;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property HorizontalScaleListBox", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///property HorizontalScaleListBox
	///</summary>
	public class HorizontalScaleListBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HorizontalScaleListBox);

		}
	}


	[NVP_Manifest(
		Text = "property HorizontalScaleListBox", 
		ViewType = "Modifier")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("pVal", typeof(System.Int32))]

	///<summary>
	///property HorizontalScaleListBox
	///</summary>
	public class Set_HorizontalScaleListBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HorizontalScaleListBox = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property HorizontalScale", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///property HorizontalScale
	///</summary>
	public class HorizontalScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HorizontalScale);

		}
	}


	[NVP_Manifest(
		Text = "property HorizontalScale", 
		ViewType = "Modifier")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property HorizontalScale
	///</summary>
	public class Set_HorizontalScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HorizontalScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property VerticalScaleListBox", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///property VerticalScaleListBox
	///</summary>
	public class VerticalScaleListBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VerticalScaleListBox);

		}
	}


	[NVP_Manifest(
		Text = "property VerticalScaleListBox", 
		ViewType = "Modifier")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("pVal", typeof(System.Int32))]

	///<summary>
	///property VerticalScaleListBox
	///</summary>
	public class Set_VerticalScaleListBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VerticalScaleListBox = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property VerticalScale", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///property VerticalScale
	///</summary>
	public class VerticalScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VerticalScale);

		}
	}


	[NVP_Manifest(
		Text = "property VerticalScale", 
		ViewType = "Modifier")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property VerticalScale
	///</summary>
	public class Set_VerticalScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VerticalScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property BasePoint", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///property BasePoint
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
		Text = "property BasePoint", 
		ViewType = "Modifier")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property BasePoint
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
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

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
	[NodeInput("MDSLProfile", typeof(object))]
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
		Text = "property MinLevel", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///property MinLevel
	///</summary>
	public class MinLevel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinLevel);

		}
	}


	[NVP_Manifest(
		Text = "property MinLevel", 
		ViewType = "Modifier")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property MinLevel
	///</summary>
	public class Set_MinLevel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MinLevel = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Supports", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///property Supports
	///</summary>
	public class Supports : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Supports);

		}
	}


	[NVP_Manifest(
		Text = "property GroundLines", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///property GroundLines
	///</summary>
	public class GroundLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GroundLines);

		}
	}


	[NVP_Manifest(
		Text = "property MinDistance", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///property MinDistance
	///</summary>
	public class MinDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinDistance);

		}
	}


	[NVP_Manifest(
		Text = "property MinDistance", 
		ViewType = "Modifier")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property MinDistance
	///</summary>
	public class Set_MinDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MinDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method GetScreenDistance", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("RealDistance", typeof(System.Double))]

	///<summary>
	///method GetScreenDistance
	///</summary>
	public class GetScreenDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetScreenDistance(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "method GetScreenDistance", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("RealHeight", typeof(System.Double))]

	///<summary>
	///method GetScreenDistance
	///</summary>
	public class GetScreenHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetScreenHeight(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "method GetScreenDistance", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("ScreenDistance", typeof(System.Double))]

	///<summary>
	///method GetScreenDistance
	///</summary>
	public class GetRealDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRealDistance(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "method GetScreenDistance", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("ScreenHeight", typeof(System.Double))]

	///<summary>
	///method GetScreenDistance
	///</summary>
	public class GetRealHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRealHeight(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "method GetStation", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]
	[NodeInput("short", typeof(System.Object))]

	///<summary>
	///method GetStation
	///</summary>
	public class GetStation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetStation(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "property LineName", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///property LineName
	///</summary>
	public class LineName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineName);

		}
	}


	[NVP_Manifest(
		Text = "property LineName", 
		ViewType = "Modifier")]
	[NodeInput("MDSLProfile", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property LineName
	///</summary>
	public class Set_LineName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method climateData", 
		ViewType = "Data")]
	[NodeInput("MDSLProfile", typeof(object))]

	///<summary>
	///method climateData
	///</summary>
	public class climateData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.climateData);

		}
	}
}
