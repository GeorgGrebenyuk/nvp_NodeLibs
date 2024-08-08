using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IcsLightningProtectionWrp Interface
///</summary>
namespace CSMSStormComLib.csLightningProtectionWrp 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class csLightningProtectionWrp_Constructor : INode 
	{
		public CSMSStormComLib.IcsLightningProtectionWrp _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as CSMSStormComLib.IcsLightningProtectionWrp;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class csLightningProtectionWrp_ConstructorCast : INode 
	{
		public CSMSStormComLib.IcsLightningProtectionWrp _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as CSMSStormComLib.IcsLightningProtectionWrp;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property ZoneType", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property ZoneType
	///</summary>
	public class ZoneType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ZoneType);

		}
	}


	[NVP_Manifest(
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

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
	[NodeInput("csLightningProtectionWrp", typeof(object))]
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
		Text = "property Reliability", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property Reliability
	///</summary>
	public class Reliability : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Reliability);

		}
	}


	[NVP_Manifest(
		Text = "property SingleRodName", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleRodName
	///</summary>
	public class SingleRodName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleRodName);

		}
	}


	[NVP_Manifest(
		Text = "property SingleRodName", 
		ViewType = "Modifier")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property SingleRodName
	///</summary>
	public class Set_SingleRodName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SingleRodName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property SingleRodHeight", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleRodHeight
	///</summary>
	public class SingleRodHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleRodHeight);

		}
	}


	[NVP_Manifest(
		Text = "property SingleRodHeight0", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleRodHeight0
	///</summary>
	public class SingleRodHeight0 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleRodHeight0);

		}
	}


	[NVP_Manifest(
		Text = "property SingleRodRadius0", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleRodRadius0
	///</summary>
	public class SingleRodRadius0 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleRodRadius0);

		}
	}


	[NVP_Manifest(
		Text = "property SingleRodRadiusX", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleRodRadiusX
	///</summary>
	public class SingleRodRadiusX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleRodRadiusX);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleRodName", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodName
	///</summary>
	public class DoubleRodName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodName);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleRodName", 
		ViewType = "Modifier")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property DoubleRodName
	///</summary>
	public class Set_DoubleRodName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DoubleRodName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property DoubleRodL", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodL
	///</summary>
	public class DoubleRodL : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodL);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleRodLMax1", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodLMax1
	///</summary>
	public class DoubleRodLMax1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodLMax1);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleRodLMax2", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodLMax2
	///</summary>
	public class DoubleRodLMax2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodLMax2);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleRodLC1", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodLC1
	///</summary>
	public class DoubleRodLC1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodLC1);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleRodLC2", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodLC2
	///</summary>
	public class DoubleRodLC2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodLC2);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleRodHeightC", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodHeightC
	///</summary>
	public class DoubleRodHeightC : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodHeightC);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleRodHeightC1", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodHeightC1
	///</summary>
	public class DoubleRodHeightC1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodHeightC1);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleRodHeightC2", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodHeightC2
	///</summary>
	public class DoubleRodHeightC2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodHeightC2);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleRodRadiusC", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodRadiusC
	///</summary>
	public class DoubleRodRadiusC : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodRadiusC);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleRodRadiusCX", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodRadiusCX
	///</summary>
	public class DoubleRodRadiusCX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodRadiusCX);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleRodLX1", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodLX1
	///</summary>
	public class DoubleRodLX1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodLX1);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleRodLX2", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleRodLX2
	///</summary>
	public class DoubleRodLX2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleRodLX2);

		}
	}


	[NVP_Manifest(
		Text = "property SingleTrosName", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleTrosName
	///</summary>
	public class SingleTrosName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleTrosName);

		}
	}


	[NVP_Manifest(
		Text = "property SingleTrosName", 
		ViewType = "Modifier")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property SingleTrosName
	///</summary>
	public class Set_SingleTrosName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SingleTrosName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property SingleTrosL", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleTrosL
	///</summary>
	public class SingleTrosL : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleTrosL);

		}
	}


	[NVP_Manifest(
		Text = "property SingleTrosMinHeight", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleTrosMinHeight
	///</summary>
	public class SingleTrosMinHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleTrosMinHeight);

		}
	}


	[NVP_Manifest(
		Text = "property SingleTrosHeight0", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleTrosHeight0
	///</summary>
	public class SingleTrosHeight0 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleTrosHeight0);

		}
	}


	[NVP_Manifest(
		Text = "property SingleTrosRadius0", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleTrosRadius0
	///</summary>
	public class SingleTrosRadius0 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleTrosRadius0);

		}
	}


	[NVP_Manifest(
		Text = "property SingleTrosRadiusX", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SingleTrosRadiusX
	///</summary>
	public class SingleTrosRadiusX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleTrosRadiusX);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosName", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosName
	///</summary>
	public class DoubleTrosName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosName);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosName", 
		ViewType = "Modifier")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property DoubleTrosName
	///</summary>
	public class Set_DoubleTrosName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DoubleTrosName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosL", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosL
	///</summary>
	public class DoubleTrosL : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosL);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosLmax", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosLmax
	///</summary>
	public class DoubleTrosLmax : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosLmax);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosLmax1", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosLmax1
	///</summary>
	public class DoubleTrosLmax1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosLmax1);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosLc", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosLc
	///</summary>
	public class DoubleTrosLc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosLc);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosMinHeight", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosMinHeight
	///</summary>
	public class DoubleTrosMinHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosMinHeight);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosMinHeight1", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosMinHeight1
	///</summary>
	public class DoubleTrosMinHeight1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosMinHeight1);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosHeight0", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosHeight0
	///</summary>
	public class DoubleTrosHeight0 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosHeight0);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosHeight01", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosHeight01
	///</summary>
	public class DoubleTrosHeight01 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosHeight01);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosRadius0", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosRadius0
	///</summary>
	public class DoubleTrosRadius0 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosRadius0);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosRadius01", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosRadius01
	///</summary>
	public class DoubleTrosRadius01 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosRadius01);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosRadiusX", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosRadiusX
	///</summary>
	public class DoubleTrosRadiusX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosRadiusX);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosRadiusX1", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosRadiusX1
	///</summary>
	public class DoubleTrosRadiusX1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosRadiusX1);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosLx", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosLx
	///</summary>
	public class DoubleTrosLx : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosLx);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosLx1", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosLx1
	///</summary>
	public class DoubleTrosLx1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosLx1);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosLmax2", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosLmax2
	///</summary>
	public class DoubleTrosLmax2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosLmax2);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosMinHeight2", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosMinHeight2
	///</summary>
	public class DoubleTrosMinHeight2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosMinHeight2);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosHeight02", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosHeight02
	///</summary>
	public class DoubleTrosHeight02 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosHeight02);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosRadius02", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosRadius02
	///</summary>
	public class DoubleTrosRadius02 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosRadius02);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosRadiusX2", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosRadiusX2
	///</summary>
	public class DoubleTrosRadiusX2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosRadiusX2);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosLx2", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosLx2
	///</summary>
	public class DoubleTrosLx2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosLx2);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosHeightC", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosHeightC
	///</summary>
	public class DoubleTrosHeightC : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosHeightC);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosRadiusC", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosRadiusC
	///</summary>
	public class DoubleTrosRadiusC : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosRadiusC);

		}
	}


	[NVP_Manifest(
		Text = "property DoubleTrosRadiusCX", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property DoubleTrosRadiusCX
	///</summary>
	public class DoubleTrosRadiusCX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleTrosRadiusCX);

		}
	}


	[NVP_Manifest(
		Text = "property ClosedTrosName", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property ClosedTrosName
	///</summary>
	public class ClosedTrosName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClosedTrosName);

		}
	}


	[NVP_Manifest(
		Text = "property ClosedTrosName", 
		ViewType = "Modifier")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property ClosedTrosName
	///</summary>
	public class Set_ClosedTrosName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ClosedTrosName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property ClosedTrosMinHeight", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property ClosedTrosMinHeight
	///</summary>
	public class ClosedTrosMinHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClosedTrosMinHeight);

		}
	}


	[NVP_Manifest(
		Text = "property ClosedTrosHeight0", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property ClosedTrosHeight0
	///</summary>
	public class ClosedTrosHeight0 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClosedTrosHeight0);

		}
	}


	[NVP_Manifest(
		Text = "property ClosedTrosD", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property ClosedTrosD
	///</summary>
	public class ClosedTrosD : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClosedTrosD);

		}
	}


	[NVP_Manifest(
		Text = "property ClosedTrosD", 
		ViewType = "Modifier")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ClosedTrosD
	///</summary>
	public class Set_ClosedTrosD : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ClosedTrosD = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property ClosedTrosS0", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property ClosedTrosS0
	///</summary>
	public class ClosedTrosS0 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClosedTrosS0);

		}
	}


	[NVP_Manifest(
		Text = "property ClosedTrosA", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property ClosedTrosA
	///</summary>
	public class ClosedTrosA : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClosedTrosA);

		}
	}


	[NVP_Manifest(
		Text = "property ClosedTrosB", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property ClosedTrosB
	///</summary>
	public class ClosedTrosB : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClosedTrosB);

		}
	}


	[NVP_Manifest(
		Text = "property MultyRodName", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property MultyRodName
	///</summary>
	public class MultyRodName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MultyRodName);

		}
	}


	[NVP_Manifest(
		Text = "property MultyRodName", 
		ViewType = "Modifier")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property MultyRodName
	///</summary>
	public class Set_MultyRodName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MultyRodName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property HeigthX", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property HeigthX
	///</summary>
	public class HeigthX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HeigthX);

		}
	}


	[NVP_Manifest(
		Text = "property HeigthX", 
		ViewType = "Modifier")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property HeigthX
	///</summary>
	public class Set_HeigthX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HeigthX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property SectionEnabled", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]

	///<summary>
	///property SectionEnabled
	///</summary>
	public class SectionEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SectionEnabled);

		}
	}


	[NVP_Manifest(
		Text = "property SectionEnabled", 
		ViewType = "Modifier")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property SectionEnabled
	///</summary>
	public class Set_SectionEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SectionEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method ConductorParameterCalc", 
		ViewType = "Data")]
	[NodeInput("csLightningProtectionWrp", typeof(object))]
	[NodeInput("nameParam", typeof(System.String))]
	[NodeInput("nConductor", typeof(System.Object))]
	[NodeInput("nMethod", typeof(System.Object))]
	[NodeInput("fReliability", typeof(System.Double))]

	///<summary>
	///method ConductorParameterCalc
	///</summary>
	public class ConductorParameterCalc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConductorParameterCalc(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}
}
