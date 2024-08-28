using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace NVP_Renga_COM._Renga.PortDuctParams 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PortDuctParams_Constructor : INode 
	{
		public Renga.IPortDuctParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IPortDuctParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PortDuctParams_ConstructorCast : INode 
	{
		public Renga.IPortDuctParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IPortDuctParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PortDuctParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ConnectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConnectionType);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PortDuctParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class DuctFormType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DuctFormType);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PortDuctParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class NominalDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NominalDiameter);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PortDuctParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class NominalWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NominalWidth);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PortDuctParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class NominalHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NominalHeight);

		}
	}
}
