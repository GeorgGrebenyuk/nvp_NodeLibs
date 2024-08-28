using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrMpInsul Interface
///</summary>
namespace NVP_ModelStudio_COM._vCSViperCSObjComLib.WrMpInsul 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrMpInsul_Constructor : INode 
	{
		public vCSViperCSObjComLib.IWrMpInsul _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as vCSViperCSObjComLib.IWrMpInsul;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrMpInsul_ConstructorCast : INode 
	{
		public vCSViperCSObjComLib.IWrMpInsul _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as vCSViperCSObjComLib.IWrMpInsul;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property ViewMode", 
		ViewType = "Data")]
	[NodeInput("WrMpInsul", typeof(object))]

	///<summary>
	///property ViewMode
	///</summary>
	public class ViewMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewMode);

		}
	}


	[NVP_Manifest(
		Text = "property ViewMode", 
		ViewType = "Modifier")]
	[NodeInput("WrMpInsul", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property ViewMode
	///</summary>
	public class Set_ViewMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property PipeCount", 
		ViewType = "Data")]
	[NodeInput("WrMpInsul", typeof(object))]

	///<summary>
	///property PipeCount
	///</summary>
	public class PipeCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PipeCount);

		}
	}


	[NVP_Manifest(
		Text = "method GetPipe", 
		ViewType = "Data")]
	[NodeInput("WrMpInsul", typeof(object))]
	[NodeInput("index", typeof(System.Object))]

	///<summary>
	///method GetPipe
	///</summary>
	public class GetPipe : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPipe(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "property Thickness", 
		ViewType = "Data")]
	[NodeInput("WrMpInsul", typeof(object))]

	///<summary>
	///property Thickness
	///</summary>
	public class Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Thickness);

		}
	}


	[NVP_Manifest(
		Text = "property Thickness", 
		ViewType = "Modifier")]
	[NodeInput("WrMpInsul", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Thickness
	///</summary>
	public class Set_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Thickness = inputs[1].Value;
			return null;
		}
	}
}
