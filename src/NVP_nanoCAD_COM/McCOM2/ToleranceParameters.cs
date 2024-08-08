using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Set of SymToleranceParameter values
///</summary>
namespace McCOM2.ToleranceParameters 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ToleranceParameters_Constructor : INode 
	{
		public McCOM2.IToleranceParameters _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IToleranceParameters;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ToleranceParameters_ConstructorCast : INode 
	{
		public McCOM2.IToleranceParameters _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IToleranceParameters;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Parameter collection's owner object", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///Parameter collection's owner object
	///</summary>
	public class Object : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Object);

		}
	}


	[NVP_Manifest(
		Text = "0x000005a4", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005a4
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Text = "0x000005a5", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("McCOM2.SymToleranceParameter", typeof(System.Object))]

	///<summary>
	///0x000005a5
	///</summary>
	public class Contains : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Contains(((McCOM2.SymToleranceParameter)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Text = "0x000005a6", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005a6
	///</summary>
	public class Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Value);

		}
	}


	[NVP_Manifest(
		Text = "0x000005a6", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000005a6
	///</summary>
	public class Set_Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Value = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005a7", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005a7
	///</summary>
	public class ParamLinear : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamLinear);

		}
	}


	[NVP_Manifest(
		Text = "0x000005a7", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005a7
	///</summary>
	public class Set_ParamLinear : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamLinear = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005a8", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005a8
	///</summary>
	public class ParamPlanar : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamPlanar);

		}
	}


	[NVP_Manifest(
		Text = "0x000005a8", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005a8
	///</summary>
	public class Set_ParamPlanar : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamPlanar = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005a9", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005a9
	///</summary>
	public class ParamRound : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamRound);

		}
	}


	[NVP_Manifest(
		Text = "0x000005a9", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005a9
	///</summary>
	public class Set_ParamRound : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamRound = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005aa", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005aa
	///</summary>
	public class ParamCylindrical : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamCylindrical);

		}
	}


	[NVP_Manifest(
		Text = "0x000005aa", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005aa
	///</summary>
	public class Set_ParamCylindrical : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamCylindrical = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005ab", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005ab
	///</summary>
	public class ParamProfile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamProfile);

		}
	}


	[NVP_Manifest(
		Text = "0x000005ab", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005ab
	///</summary>
	public class Set_ParamProfile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamProfile = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005ac", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005ac
	///</summary>
	public class ParamParallel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamParallel);

		}
	}


	[NVP_Manifest(
		Text = "0x000005ac", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005ac
	///</summary>
	public class Set_ParamParallel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamParallel = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005ad", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005ad
	///</summary>
	public class ParamPerpendicular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamPerpendicular);

		}
	}


	[NVP_Manifest(
		Text = "0x000005ad", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005ad
	///</summary>
	public class Set_ParamPerpendicular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamPerpendicular = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005ae", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005ae
	///</summary>
	public class ParamTilt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamTilt);

		}
	}


	[NVP_Manifest(
		Text = "0x000005ae", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005ae
	///</summary>
	public class Set_ParamTilt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamTilt = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005af", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005af
	///</summary>
	public class ParamCoaxiality : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamCoaxiality);

		}
	}


	[NVP_Manifest(
		Text = "0x000005af", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005af
	///</summary>
	public class Set_ParamCoaxiality : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamCoaxiality = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005b0", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005b0
	///</summary>
	public class ParamSymmetry : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamSymmetry);

		}
	}


	[NVP_Manifest(
		Text = "0x000005b0", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005b0
	///</summary>
	public class Set_ParamSymmetry : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamSymmetry = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005b1", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005b1
	///</summary>
	public class ParamPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamPosition);

		}
	}


	[NVP_Manifest(
		Text = "0x000005b1", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005b1
	///</summary>
	public class Set_ParamPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005b2", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005b2
	///</summary>
	public class ParamCross : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamCross);

		}
	}


	[NVP_Manifest(
		Text = "0x000005b2", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005b2
	///</summary>
	public class Set_ParamCross : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamCross = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005b3", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005b3
	///</summary>
	public class ParamBeat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamBeat);

		}
	}


	[NVP_Manifest(
		Text = "0x000005b3", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005b3
	///</summary>
	public class Set_ParamBeat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamBeat = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005b4", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005b4
	///</summary>
	public class ParamFullBeat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamFullBeat);

		}
	}


	[NVP_Manifest(
		Text = "0x000005b4", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005b4
	///</summary>
	public class Set_ParamFullBeat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamFullBeat = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005b5", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005b5
	///</summary>
	public class ParamFormProfile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamFormProfile);

		}
	}


	[NVP_Manifest(
		Text = "0x000005b5", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005b5
	///</summary>
	public class Set_ParamFormProfile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamFormProfile = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005b6", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005b6
	///</summary>
	public class ParamFormSurface : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamFormSurface);

		}
	}


	[NVP_Manifest(
		Text = "0x000005b6", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005b6
	///</summary>
	public class Set_ParamFormSurface : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamFormSurface = inputs[1].Value;
			return null;
		}
	}
}
