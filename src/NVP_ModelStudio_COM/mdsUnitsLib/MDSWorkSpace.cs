using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSWorkSpace Interface
///</summary>
namespace mdsUnitsLib.MDSWorkSpace 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSWorkSpace_Constructor : INode 
	{
		public mdsUnitsLib.IMDSWorkSpace _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IMDSWorkSpace;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSWorkSpace_ConstructorCast : INode 
	{
		public mdsUnitsLib.IMDSWorkSpace _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IMDSWorkSpace;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property Name", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property Name
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
		Text = "property Name", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Name
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
		Text = "property WSPosition", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WSPosition
	///</summary>
	public class WSPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WSPosition);

		}
	}


	[NVP_Manifest(
		Text = "property WSPosition", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property WSPosition
	///</summary>
	public class Set_WSPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WSPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property RotateAroundX", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property RotateAroundX
	///</summary>
	public class RotateAroundX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RotateAroundX);

		}
	}


	[NVP_Manifest(
		Text = "property RotateAroundX", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property RotateAroundX
	///</summary>
	public class Set_RotateAroundX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RotateAroundX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property RotateAroundY", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property RotateAroundY
	///</summary>
	public class RotateAroundY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RotateAroundY);

		}
	}


	[NVP_Manifest(
		Text = "property RotateAroundY", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property RotateAroundY
	///</summary>
	public class Set_RotateAroundY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RotateAroundY = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property RotateAroundZ", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property RotateAroundZ
	///</summary>
	public class RotateAroundZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RotateAroundZ);

		}
	}


	[NVP_Manifest(
		Text = "property RotateAroundZ", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property RotateAroundZ
	///</summary>
	public class Set_RotateAroundZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RotateAroundZ = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property LimitationType", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property LimitationType
	///</summary>
	public class LimitationType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LimitationType);

		}
	}


	[NVP_Manifest(
		Text = "property LimitationType", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property LimitationType
	///</summary>
	public class Set_LimitationType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LimitationType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property WSShowLimitationGraphics", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WSShowLimitationGraphics
	///</summary>
	public class WSShowLimitationGraphics : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WSShowLimitationGraphics);

		}
	}


	[NVP_Manifest(
		Text = "property WSShowLimitationGraphics", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property WSShowLimitationGraphics
	///</summary>
	public class Set_WSShowLimitationGraphics : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WSShowLimitationGraphics = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property WSShowGraphicsUCS", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WSShowGraphicsUCS
	///</summary>
	public class WSShowGraphicsUCS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WSShowGraphicsUCS);

		}
	}


	[NVP_Manifest(
		Text = "property WSShowGraphicsUCS", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property WSShowGraphicsUCS
	///</summary>
	public class Set_WSShowGraphicsUCS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WSShowGraphicsUCS = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property WSBasePointLimitation", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WSBasePointLimitation
	///</summary>
	public class WSBasePointLimitation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WSBasePointLimitation);

		}
	}


	[NVP_Manifest(
		Text = "property WSBasePointLimitation", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property WSBasePointLimitation
	///</summary>
	public class Set_WSBasePointLimitation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WSBasePointLimitation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property WS_LXP", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WS_LXP
	///</summary>
	public class WS_LXP : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WS_LXP);

		}
	}


	[NVP_Manifest(
		Text = "property WS_LXP", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property WS_LXP
	///</summary>
	public class Set_WS_LXP : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WS_LXP = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property WS_LXM", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WS_LXM
	///</summary>
	public class WS_LXM : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WS_LXM);

		}
	}


	[NVP_Manifest(
		Text = "property WS_LXM", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property WS_LXM
	///</summary>
	public class Set_WS_LXM : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WS_LXM = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property WS_LYP", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WS_LYP
	///</summary>
	public class WS_LYP : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WS_LYP);

		}
	}


	[NVP_Manifest(
		Text = "property WS_LYP", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property WS_LYP
	///</summary>
	public class Set_WS_LYP : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WS_LYP = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property WS_LYM", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WS_LYM
	///</summary>
	public class WS_LYM : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WS_LYM);

		}
	}


	[NVP_Manifest(
		Text = "property WS_LYM", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property WS_LYM
	///</summary>
	public class Set_WS_LYM : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WS_LYM = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property WS_LZP", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WS_LZP
	///</summary>
	public class WS_LZP : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WS_LZP);

		}
	}


	[NVP_Manifest(
		Text = "property WS_LZP", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property WS_LZP
	///</summary>
	public class Set_WS_LZP : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WS_LZP = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property WS_LZM", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WS_LZM
	///</summary>
	public class WS_LZM : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WS_LZM);

		}
	}


	[NVP_Manifest(
		Text = "property WS_LZM", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property WS_LZM
	///</summary>
	public class Set_WS_LZM : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WS_LZM = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property WS_LR", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

	///<summary>
	///property WS_LR
	///</summary>
	public class WS_LR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WS_LR);

		}
	}


	[NVP_Manifest(
		Text = "property WS_LR", 
		ViewType = "Modifier")]
	[NodeInput("MDSWorkSpace", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property WS_LR
	///</summary>
	public class Set_WS_LR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WS_LR = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("MDSWorkSpace", typeof(object))]

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
	[NodeInput("MDSWorkSpace", typeof(object))]
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
}
