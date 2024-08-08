using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSLLinkSketchMode Interface
///</summary>
namespace mdsLINEComLib.MDSLLinkSketchMode 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLLinkSketchMode_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLLinkSketchMode _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLLinkSketchMode;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLLinkSketchMode_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLLinkSketchMode _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLLinkSketchMode;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property WireLength", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

	///<summary>
	///property WireLength
	///</summary>
	public class WireLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WireLength);

		}
	}


	[NVP_Manifest(
		Text = "property Sigma", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

	///<summary>
	///property Sigma
	///</summary>
	public class Sigma : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Sigma);

		}
	}


	[NVP_Manifest(
		Text = "property Gamma", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

	///<summary>
	///property Gamma
	///</summary>
	public class Gamma : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Gamma);

		}
	}


	[NVP_Manifest(
		Text = "property InitialModeIndex", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

	///<summary>
	///property InitialModeIndex
	///</summary>
	public class InitialModeIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InitialModeIndex);

		}
	}


	[NVP_Manifest(
		Text = "property SpanLength", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

	///<summary>
	///property SpanLength
	///</summary>
	public class SpanLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SpanLength);

		}
	}


	[NVP_Manifest(
		Text = "property InitialSigma", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

	///<summary>
	///property InitialSigma
	///</summary>
	public class InitialSigma : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InitialSigma);

		}
	}


	[NVP_Manifest(
		Text = "property InitialGamma", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

	///<summary>
	///property InitialGamma
	///</summary>
	public class InitialGamma : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InitialGamma);

		}
	}


	[NVP_Manifest(
		Text = "property InitialT", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

	///<summary>
	///property InitialT
	///</summary>
	public class InitialT : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InitialT);

		}
	}


	[NVP_Manifest(
		Text = "method GetGammaStd", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

	///<summary>
	///method GetGammaStd
	///</summary>
	public class GetGammaStd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGammaStd);

		}
	}


	[NVP_Manifest(
		Text = "property MinX", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

	///<summary>
	///property MinX
	///</summary>
	public class MinX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinX);

		}
	}


	[NVP_Manifest(
		Text = "property MinZ", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

	///<summary>
	///property MinZ
	///</summary>
	public class MinZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinZ);

		}
	}


	[NVP_Manifest(
		Text = "property SlackMin", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

	///<summary>
	///property SlackMin
	///</summary>
	public class SlackMin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SlackMin);

		}
	}


	[NVP_Manifest(
		Text = "property SlackMax", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

	///<summary>
	///property SlackMax
	///</summary>
	public class SlackMax : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SlackMax);

		}
	}


	[NVP_Manifest(
		Text = "method GetSlackMaxAt", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///method GetSlackMaxAt
	///</summary>
	public class GetSlackMaxAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetSlackMaxAt(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "property Length", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

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
		Text = "property SlackSpan", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]
	[NodeInput("nSpanNum", typeof(System.Int32))]

	///<summary>
	///property SlackSpan
	///</summary>
	public class SlackSpan : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SlackSpan(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "property WindAngle", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

	///<summary>
	///property WindAngle
	///</summary>
	public class WindAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WindAngle);

		}
	}


	[NVP_Manifest(
		Text = "method GetGammaNorm", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

	///<summary>
	///method GetGammaNorm
	///</summary>
	public class GetGammaNorm : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGammaNorm);

		}
	}


	[NVP_Manifest(
		Text = "method GetGammaCalc", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkSketchMode", typeof(object))]

	///<summary>
	///method GetGammaCalc
	///</summary>
	public class GetGammaCalc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGammaCalc);

		}
	}
}
